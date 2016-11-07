using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UnitTest017
{
    public class Block
    {
        public int ID { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public DateTime UpdateDate { get; set; }
    }


    class Target
    {
        public Target()
        {

        }

        public Block Load(string file)
        {
            return null;
        }
        public bool Save(string file, Block b )
        {
            return false;
        }
    }
}
