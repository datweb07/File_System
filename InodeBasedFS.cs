using System;
using System.Collections.Generic;

namespace File_System
{
    public class InodeBasedFS
    {
        public List<Inode> inodes;   // Danh sách các inode (danh sách các file đã tạo)
        public bool[] blockMap;      // Bảng ánh xạ block (true nếu block đã được cấp phát, false nếu chưa)
        public int blockSize;
        public int maxBlocks;

        public InodeBasedFS(int blockSize = 4096, int maxBlocks = 100)
        {
            this.blockSize = blockSize;
            this.maxBlocks = maxBlocks;
            inodes = new List<Inode>();
            blockMap = new bool[maxBlocks];
        }

        // Tạo file và cấp phát block nếu đủ bộ nhớ
        public bool CreateFile(string fileName, int size)
        {
            int blocksNeeded = (int)Math.Ceiling((double)size / blockSize);   // Tinh số block cần thiết
            List<int> freeBlocks = new List<int>();

            // Tìm block trống
            for (int i = 0; i < maxBlocks && freeBlocks.Count < blocksNeeded; i++)
            {
                if (!blockMap[i])
                {
                    freeBlocks.Add(i);
                }
            }

            if (freeBlocks.Count < blocksNeeded)
            {
                return false; // Nếu không đủ bộ nhớ trả về false
            }

            Inode inode = new Inode(fileName, size);
            foreach (int block in freeBlocks)
            {
                // Cấp phát block cho file và tạo inode
                blockMap[block] = true;
                inode.Blocks.Add(block);
            }

            // Thêm inode vào danh sách inode
            inodes.Add(inode);
            return true;
        }

        // In ra các thông số của IBFS
        public string GetFileSystemInfo()
        {
            int freeBlocks = 0;
            foreach (bool block in blockMap)
            {
                if (!block) 
                { 
                    freeBlocks++; 
                }
            }

            return $"Block Size: {blockSize} bytes\t" +
                   $"Total Blocks: {maxBlocks}\t" +
                   $"Free Blocks: {freeBlocks}\t" +
                   $"Used Blocks: {maxBlocks - freeBlocks}\t" +
                   $"Files: {inodes.Count}";
        }
    }
}
