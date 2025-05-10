using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace File_System
{
    public class InodeBasedFS
    {
        public List<Inode> inodes;
        public bool[] blockMap;
        public int blockSize;
        public int maxBlocks;

        public InodeBasedFS(int blockSize = 4096, int maxBlocks = 100)
        {
            this.blockSize = blockSize;
            this.maxBlocks = maxBlocks;
            inodes = new List<Inode>();
            blockMap = new bool[maxBlocks];
        }

        // Tạo file IBFS
        public bool CreateFile(string fileName, int size)
        {
            int blocksNeeded = (int)Math.Ceiling((double)size / blockSize);
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
                return false; // Không đủ bộ nhớ trống
            }

            // Allocate blocks
            Inode inode = new Inode(fileName, size);
            foreach (int block in freeBlocks)
            {
                blockMap[block] = true;
                inode.Blocks.Add(block);
            }

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
