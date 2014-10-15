using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03FileDirectoryTree
{
    public class DirectoryTree
    {
        public Folder Root { get; set; }

        public DirectoryTree(Folder rootDirectory)
        {
            this.Root = rootDirectory;
        }
    }
}