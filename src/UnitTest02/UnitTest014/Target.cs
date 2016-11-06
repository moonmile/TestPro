using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest014
{
    struct Block
    {
        public int ID;
        public byte A, R, G, B;
    }

    class Target
    {
        public Target()
        {
        }
        public bool OpenRead(string file)
        {
            return false;
        }
        public bool OpenWrite(string file)
        {
            return false;
        }
        public void Close()
        {
        }
        public Block ReadBlock()
        {
            return new Block();
        }
        public int WriteBlock( Block n )
        {
            return 0;
        }
        public int WriteBlock(Block []n)
        {
            return 0;
        }
    }
}
