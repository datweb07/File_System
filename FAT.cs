using System;
using System.Collections.Generic;

namespace File_System
{
    public class FAT
    {
        public List<string> fatTable;          // Bảng FAT (mỗi phần tử là một cluster)
        public Dictionary<int, string> files;  // Danh sách các file đã tạo (key: cluster, value: tên file)
        public int clusterSize;
        public int maxClusters;

        public FAT(int clusterSize = 4096, int maxClusters = 100)
        {
            this.clusterSize = clusterSize;
            this.maxClusters = maxClusters;
            fatTable = new List<string>(new string[maxClusters]);
            files = new Dictionary<int, string>();
            InitializeFAT();   // Khởi tạo bảng FAT với tất cả các cluster là "FREE" (chưa sử dụng)
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
            int clustersNeeded = (int)Math.Ceiling((double)size / clusterSize);    // Tính số cluster cần dùng
            List<int> freeClusters = new List<int>();

            // Tìm các cluster còn trống
            for (int i = 0; i < maxClusters && freeClusters.Count < clustersNeeded; i++)
            {
                if (fatTable[i] == "FREE")
                {
                    freeClusters.Add(i);
                }
            }

            // Kiểm tra đủ cluser hay không
            if (freeClusters.Count < clustersNeeded)
            {
                return false; 
            }

            // Cấp phát cluster cho file
            for (int i = 0; i < freeClusters.Count; i++)
            {
                if (i == freeClusters.Count - 1)  // Nếu là cluster cuối cùng
                {
                    fatTable[freeClusters[i]] = "EOF";   // Đánh dấu EOF (End of File) cho cluster cuối cùng
                }
                else
                {
                    fatTable[freeClusters[i]] = freeClusters[i + 1].ToString();   // Chỉ định cluster tiếp theo
                }
            }

            // Ghi tên file vào dictionary
            files.Add(freeClusters[0], fileName);
            return true;
        }

        public string GetFileSystemInfo()
        {
            int freeClusters = 0;
            foreach (string entry in fatTable)
            {
                if (entry == "FREE")
                {
                    freeClusters++;   // Đếm số cluster còn trống
                }
            }

            return $"FAT File System\n" +
                   $"Cluster Size: {clusterSize} bytes\n" +
                   $"Total Clusters: {maxClusters}\n" +
                   $"Free Clusters: {freeClusters}\n" +
                   $"Used Clusters: {maxClusters - freeClusters}\n";
        }
    }
}
