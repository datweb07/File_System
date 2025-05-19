using System;
using System.Collections.Generic;

namespace File_System
{
    public class Inode
    {
        public string FileName { get; set; }        // Tên file
        public int Size { get; set; }               // Kích thước file (bytes)
        public List<int> Blocks { get; set; }       // Danh sách các block (cluster) mà file được cấp phát
        public DateTime CreationTime { get; set; }  // Thời gian tạo file

        public Inode(string fileName, int size)
        {
            FileName = fileName;
            Size = size;
            Blocks = new List<int>();               // Khởi tạo danh sách block rỗng
            CreationTime = DateTime.Now;
        }
    }
}
