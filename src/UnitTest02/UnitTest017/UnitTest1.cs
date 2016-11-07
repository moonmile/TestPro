using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace UnitTest017
{
    /// <summary>
    /// 問17
    /// XMLのシリアライザを利用して、以下のメソッドを実装せよ
    /// </summary>

    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Setup()
        {
            System.IO.File.Delete("output.xml");
        }
        [TestCleanup]
        public void Cleanup()
        {
            System.IO.File.Delete("output.xml");
        }

        [TestMethod]
        public void シリアライザでデータ読み込み()
        {
            var a = new Target();
            var b = a.Load("input.xml");

            Assert.AreEqual(100, b.ID);
            Assert.AreEqual("username", b.User);
            Assert.AreEqual(new DateTime(2017, 3, 4), b.UpdateDate);
        }

        [TestMethod]
        public void シリアライザでデータ書き出し()
        {
            var b = new Block
            {
                ID = 100,
                User = "username",
                Pass = "p@ssw0rd",
                UpdateDate = new DateTime(2017, 3, 4),
            };

            var a = new Target();
            a.Save("output.xml", b);

            var se = new System.Xml.Serialization.XmlSerializer(typeof(Block));
            var sw = new System.IO.StreamWriter("output.xml");
            se.Serialize(sw, b);
            sw.Close();

            var sr = new StreamReader("output.xml");
            var bb = se.Deserialize(sr) as Block;
            sr.Close();

            Assert.AreEqual(100, bb.ID);
            Assert.AreEqual("username", bb.User);
            Assert.AreEqual(new DateTime(2017, 3, 4), bb.UpdateDate);
        }
    }
}
