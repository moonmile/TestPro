using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest008
{
    class Target
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public void SetColor( string name )
        {
            
        }
        public Target ToLight( int n )
        {
            return this;
        }
        public Target RedOnly()
        {
            return this;
        }
    }
}
