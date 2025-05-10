using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_System
{
    public class FAT
    {
        public List<string> fatTable;
        public Dictionary<int, string> files;
        public int clusterSize;
        public int maxClusters;

        public FAT(int clusterSize = 4096, int maxClusters = 100)
        {
            this.clusterSize = clusterSize;
            this.maxClusters = maxClusters;
            fatTable = new List<string>(new string[maxClusters]);
            files = new Dictionary<int, string>();
            InitializeFAT();
        }

        public void InitializeFAT()
        {
            for (int i = 0; i < maxClusters; i++)
            {
                fatTable[i] = "FREE";
            }
        }

        public bool CreateFile(string fileName, int size)
        {
            // Math.Ceiling làm tròn lên số nguyên gấn nhất (nếu có phần thập phân)
            int clustersNeeded = (int)Math.Ceiling((double)size / clusterSize);
            List<int> freeClusters = new List<int>();

            // Find free clusters
            for (int i = 0; i < maxClusters && freeClusters.Count < clustersNeeded; i++)
            {
                if (fatTable[i] == "FREE")
                {
                    freeClusters.Add(i);
                }
            }

            if (freeClusters.Count < clustersNeeded)
            {
                return false; // Not enough space
            }

            // Allocate clusters
            for (int i = 0; i < freeClusters.Count; i++)
            {
                //fatTable[freeClusters[i]] = (i == freeClusters.Count - 1) ? "EOF" : freeClusters[i + 1].ToString();
                if (i == freeClusters.Count - 1)
                {
                    fatTable[freeClusters[i]] = "EOF";
                }
                else
                {
                    fatTable[freeClusters[i]] = freeClusters[i + 1].ToString();
                }

            }

            files.Add(freeClusters[0], fileName);
            return true;
        }

        public string GetFileSystemInfo()
        {
            //int freeClusters = fatTable.FindAll(x => x == "FREE").Count;
            int freeClusters = 0;
            foreach (string entry in fatTable)
            {
                if (entry == "FREE")
                {
                    freeClusters++;
                }
            }

            return $"Cluster Size: {clusterSize} bytes\t" +
                   $"Total Clusters: {maxClusters}\t" +
                   $"Free Clusters: {freeClusters}\t" +
                   $"Used Clusters: {maxClusters - freeClusters}\t" +
                   $"Files: {files.Count}";
        }
    }
}
