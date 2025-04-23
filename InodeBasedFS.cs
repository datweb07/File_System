using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_System
{
    public class InodeBasedFS
    {
        private class Inode
        {
            public string FileName { get; set; }
            public int Size { get; set; }
            public List<int> Blocks { get; set; }
            public DateTime CreationTime { get; set; }

            public Inode(string fileName, int size)
            {
                FileName = fileName;
                Size = size;
                Blocks = new List<int>();
                CreationTime = DateTime.Now;
            }
        }

        private List<Inode> inodes;
        private bool[] blockMap;
        private int blockSize;
        private int maxBlocks;

        public InodeBasedFS(int blockSize = 4096, int maxBlocks = 100)
        {
            this.blockSize = blockSize;
            this.maxBlocks = maxBlocks;
            inodes = new List<Inode>();
            blockMap = new bool[maxBlocks];
        }

        public bool CreateFile(string fileName, int size)
        {
            int blocksNeeded = (int)Math.Ceiling((double)size / blockSize);
            List<int> freeBlocks = new List<int>();

            // Find free blocks
            for (int i = 0; i < maxBlocks && freeBlocks.Count < blocksNeeded; i++)
            {
                if (!blockMap[i])
                {
                    freeBlocks.Add(i);
                }
            }

            if (freeBlocks.Count < blocksNeeded)
            {
                return false; // Not enough space
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

        public string GetFileSystemInfo()
        {
            int freeBlocks = 0;
            foreach (bool block in blockMap)
            {
                if (!block) freeBlocks++;
            }

            return $"Inode-based File System\n" +
                   $"Block Size: {blockSize} bytes\n" +
                   $"Total Blocks: {maxBlocks}\n" +
                   $"Free Blocks: {freeBlocks}\n" +
                   $"Used Blocks: {maxBlocks - freeBlocks}\n" +
                   $"Files: {inodes.Count}";
        }
    }
}
