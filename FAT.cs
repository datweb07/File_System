using System;
using System.Collections.Generic;
using System.Linq;

namespace File_System
{
    public class FAT
    {
        public List<string> fatTable;                      // Bảng FAT (mỗi phần tử là một cluster)
        public Dictionary<int, string> files;              // Danh sách các file đã tạo (key: cluster, value: tên file)
        public Dictionary<string, string> fileContents;    // Dữ liệu của files (key: tên file, value: nội dung file)
        public int clusterSize;
        public int maxClusters;

        public FAT(int clusterSize = 4096, int maxClusters = 100)
        {
            this.clusterSize = clusterSize;
            this.maxClusters = maxClusters;
            fatTable = new List<string>(new string[maxClusters]);
            files = new Dictionary<int, string>();
            fileContents = new Dictionary<string, string>();
            InitializeFAT();
        }

        // Khởi tạo bảng FAT với tất cả các cluster là "FREE" (chưa sử dụng)
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
            int clustersNeeded = (int)Math.Ceiling((double)size / clusterSize);         // Tính số cluster cần dùng
            List<int> freeClusters = new List<int>();                                   // Tạo danh sách các cluster trống

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
                return false; // Không đủ khoảng trống
            }

            // Cấp phát cluster cho file
            for (int i = 0; i < freeClusters.Count; i++)
            {
                if (i == freeClusters.Count - 1)                  // Nếu là cluster cuối cùng
                {
                    fatTable[freeClusters[i]] = "END OF FILE";    // Đánh dấu End of File cho cluster cuối cùng
                }
                else
                {
                    fatTable[freeClusters[i]] = freeClusters[i + 1].ToString();      // Chỉ định cluster tiếp theo
                }    
            }

            // Ghi tên file với cluster đầu tiên
            files.Add(freeClusters[0], fileName);

            // Khởi tạo nội dung rỗng
            fileContents[fileName] = "";
            return true;
        }

        public bool DeleteFile(string fileName)
        {
            // Tìm cluster bắt đầu của file
            var entry = files.FirstOrDefault(p => p.Value == fileName);

            if (entry.Value == null)
            {
                return false;
            }

            int current = entry.Key;

            // Lần lượt giải phóng từng cluster
            while (fatTable[current] != "END OF FILE")
            {
                int next = int.Parse(fatTable[current]);
                fatTable[current] = "FREE";
                current = next;
            }
            fatTable[current] = "FREE";

            // Xóa file khỏi danh sách
            files.Remove(entry.Key);
            fileContents.Remove(fileName);
            return true;
        }

        public string GetFileSystemInfo()
        {
            // Tính toán số cluster còn trống
            int freeClusters = 0;
            foreach (string c in fatTable)
            {
                if (c == "FREE")
                {
                    freeClusters++;
                }
            }

            // Trả về thông tin của file
            return $"Cluster Size: {clusterSize} bytes\n" +
                   $"Total Clusters: {maxClusters}\n" +
                   $"Free Clusters: {freeClusters}\n" +
                   $"Used Clusters: {maxClusters - freeClusters}\n" +
                   $"Files: {files.Count}";
        }

        // Mô phỏng trạng thái của FAT
        public string GetMemory()
        {
            string result = "";
            foreach (string c in fatTable)
            {
                if (c == "FREE")
                {
                    result += "F";
                }
                else if (c == "END OF FILE")
                {
                    result += "E";
                }
                else
                {
                    result += "U";
                }
            }
            return result;
        }

        // Trả về danh sách các file đã tạo
        public List<string> GetFileList()
        {
            List<string> fileList = new List<string>();
            foreach (string value in files.Values)
            {
                fileList.Add(value);
            }
            return fileList;
        }

        // Trả về nội dung của file
        public string ReadFile(string fileName)
        {
            string data;
            bool found = fileContents.TryGetValue(fileName, out data);
            if (found)
            {
                return data;
            }
            else
            {
                return "Empty contents";
            }
        }

        // Ghi nội dung vào file
        public void WriteToFile(string fileName, string content)
        {
            if (fileContents.ContainsKey(fileName))
            {
                fileContents[fileName] = content;
            }
        }
    }
}
