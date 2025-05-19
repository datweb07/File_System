using System;
using System.Collections.Generic;

namespace File_System
{
    public class InodeBasedFS
    {
        public List<Inode> inodes;                          // Danh sách các inode (danh sách các file đã tạo)
        public Dictionary<string, string> fileContents;     // Dữ liệu của files (key: tên file, value: nội dung file)
        public bool[] blockMap;                             // Bảng ánh xạ block (true nếu block đã được cấp phát, false nếu chưa)
        public int blockSize;
        public int maxBlocks;

        public InodeBasedFS(int blockSize = 4096, int maxBlocks = 100)
        {
            this.blockSize = blockSize;
            this.maxBlocks = maxBlocks;
            inodes = new List<Inode>();
            fileContents = new Dictionary<string, string>();
            blockMap = new bool[maxBlocks];
        }

        // Tạo file và cấp phát block nếu đủ bộ nhớ
        public bool CreateFile(string fileName, int size)
        {
            // Tinh số block cần thiết
            int blocksNeeded = (int)Math.Ceiling((double)size / blockSize);

            List<int> freeBlocks = new List<int>();                                // Tạo danh sách các block còn trống

            // Tìm các block trống
            for (int i = 0; i < maxBlocks && freeBlocks.Count < blocksNeeded; i++)
            {
                if (!blockMap[i])
                {
                    freeBlocks.Add(i);
                }
            }

            // Kiểm tra có đủ block hay không
            if (freeBlocks.Count < blocksNeeded) 
            { 
                return false; 
            }

            // Tạo inode và gán block
            Inode inode = new Inode(fileName, size);
            foreach (int block in freeBlocks)
            {
                blockMap[block] = true;       // Đánh dấu block đã được sử dụng
                inode.Blocks.Add(block);      // Ghi block vào inode
            }

            // Thêm inode vào danh sách inode
            inodes.Add(inode);

            // Khởi tạo nội dung file rỗng
            fileContents[fileName] = "";
            return true;
        }

        // Xóa file và giải phóng block
        public bool DeleteFile(string fileName)
        {
            Inode inode = null;

            // Tìm inode tương ứng với tên file
            foreach (Inode i in inodes)
            {
                if (i.FileName == fileName)
                {
                    inode = i;
                    break;
                }
            }

            if (inode == null) 
            { 
                return false; 
            }

            // Giải phóng các block đã cấp phát cho file    
            foreach (int block in inode.Blocks)
            {
                blockMap[block] = false;
            }

            // Xóa inode và nội dung file khỏi danh sách
            inodes.Remove(inode);
            fileContents.Remove(fileName);
            return true;
        }

        // Hiển thị thông tin file
        public string GetFileSystemInfo()
        {
            int freeBlocks = 0;
            foreach (bool b in blockMap)
            {
                if (!b)
                {
                    freeBlocks++;
                }
            }
            return $"Block Size: {blockSize} bytes\n" +
                   $"Total Blocks: {maxBlocks}\n" +
                   $"Free Blocks: {freeBlocks}\n" +
                   $"Used Blocks: {maxBlocks - freeBlocks}\n" +
                   $"Files: {inodes.Count}";
        }

        // Mô phỏng bộ nhớ
        public string GetMemory()
        {
            string result = "";
            foreach (bool b in blockMap)
            {
                if (b)
                {
                    result += "U";    // Đã được sử dụng
                }
                else
                {
                    result += "F";    // Còn trống
                }
            }
            return result;


        }

        // Danh sách các file đã tạo
        public List<string> GetFileList()
        {
            List<string> fileNames = new List<string>();
            foreach (Inode i in inodes)
            {
                fileNames.Add(i.FileName);
            }
            return fileNames;
        }

        // Đọc nội dung file
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

        // Viết nội dung vào file
        public void WriteToFile(string fileName, string content)
        {
            if (fileContents.ContainsKey(fileName))
            {
                fileContents[fileName] = content;
            }
        }
    }
}
