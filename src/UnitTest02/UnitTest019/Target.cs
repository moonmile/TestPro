using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UnitTest019
{

    class Target
    {
        MemoryStream _mem;
        public Target( MemoryStream mem )
        {
            _mem = mem;
        }
        public byte[] ToBytes()
        {
            return _mem.ToArray(); 

        }
        public void Init( int n )
        {

        }
        public void Init( byte[] data )
        {

        }
        public void Clear()
        {

        }
    }
}
