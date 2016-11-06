using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest013
{
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
        public byte ReadByte()
        {
            return 0;
        }
        public int WriteByte( byte n )
        {
            return 0;
        }

        public byte[] ReadBytes( int n )
        {
            return null;
        }
        public int WriteBytes( byte[] data )
        {
            return 0;
        }
    }
}
