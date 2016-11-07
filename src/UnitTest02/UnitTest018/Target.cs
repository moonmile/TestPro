using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace UnitTest018
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

        public Block LoadJson(string str)
        {
            return null;
        }
        public Block LoadXml(string str)
        {
            return null;
        }
    }
}
