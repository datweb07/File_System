using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_System
{
    public class FAT
    {
        private List<string> fatTable;
        private Dictionary<int, string> files;
        private int clusterSize;
        private int maxClusters;

        public FAT(int clusterSize = 4096, int maxClusters = 100)
        {
            this.clusterSize = clusterSize;
            this.maxClusters = maxClusters;
            fatTable = new List<string>(new string[maxClusters]);
            files = new Dictionary<int, string>();
            InitializeFAT();
        }

        private void InitializeFAT()
        {
            for (int i = 0; i < maxClusters; i++)
            {
                fatTable[i] = "FREE";
            }
        }

        public bool CreateFile(string fileName, int size)
        {
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
                fatTable[freeClusters[i]] = (i == freeClusters.Count - 1) ? "EOF" : freeClusters[i + 1].ToString();
            }

            files.Add(freeClusters[0], fileName);
            return true;
        }

        public string GetFileSystemInfo()
        {
            int freeClusters = fatTable.FindAll(x => x == "FREE").Count;
            return $"FAT File System\n" +
                   $"Cluster Size: {clusterSize} bytes\n" +
                   $"Total Clusters: {maxClusters}\n" +
                   $"Free Clusters: {freeClusters}\n" +
                   $"Used Clusters: {maxClusters - freeClusters}\n" +
                   $"Files: {files.Count}";
        }
    }
}
