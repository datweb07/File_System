using System;
using System.Collections.Generic;

namespace File_System
{
    public class Inode
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
}
