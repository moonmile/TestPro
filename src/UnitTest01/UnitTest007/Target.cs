using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest007
{
    class Target
    {
        public List<string> Items { get; set; }

        public int Count
        {
            get { return 0; }
        }

        public int Search( string s )
        {
            return 0;
        }
        public List<string> Include(string s)
        {
            return null;
        }
    }
}
