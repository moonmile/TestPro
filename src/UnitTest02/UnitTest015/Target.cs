using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UnitTest015
{
    class Block
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }

    class Target
    {
        public Target()
        {

        }

        public Block LoadBlock( string file )
        {
            return null;
        }
        public List<Block> LoadBlocks(string file)
        {
            return null;
        }
        public Block SearchBlock(string file, int id )
        {
            return null;
        }
        public List<string> GetNames(string file)
        {
            return null;
        }

        public bool SaveBlock(string file, Block block )
        {
            return false;
        }
        public bool SaveBlocks(string file, Block[] lst)
        {
            return false;
        }
    }
}
