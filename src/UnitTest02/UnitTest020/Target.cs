using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest020
{

    class Target
    {
        public Target()
        {
        }

        public bool FileExists( string dir, string path )
        {
            return true;
        }
        public bool DirExists(string dir)
        {
            return true;
        }
        public List<string> GetFiles(string dir, string path)
        {
            return null;
        }
    }
}
