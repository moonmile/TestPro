using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace UnitTest014
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Setup()
        {
            System.IO.File.Delete("output.dat");
        }
        [TestCleanup]
        public void Cleanup()
        {
            System.IO.File.Delete("output.dat");
        }

        [TestMethod]
        public void 単一ブロックの読み込み()
        {
            var a = new Target();
            a.OpenRead("input.dat");
            var bk = a.ReadBlock();

            Assert.AreEqual(0x10, bk.ID);
            Assert.AreEqual(255, bk.A);
            Assert.AreEqual(100, bk.R);
            Assert.AreEqual(0, bk.G);
            Assert.AreEqual(0, bk.B);
            a.Close();
        }

        [TestMethod]
        public void 複数ブロックの読み込み()
        {
            var a = new Target();
            a.OpenRead("input.dat");
            var bk = a.ReadBlock();
            Assert.AreEqual(0x10, bk.ID);
            bk = a.ReadBlock();
            Assert.AreEqual(0x20, bk.ID);
            bk = a.ReadBlock();
            Assert.AreEqual(0x30, bk.ID);
            a.Close();
        }
        [TestMethod]
        public void 単一ブロックの書き出し()
        {
            var a = new Target();
            a.OpenWrite("output.dat");
            var bk = new Block { ID = 0x11, A = 0xFF, R = 0xA0, G = 0x00, B = 0x00 };
            int n = a.WriteBlock(bk);
            Assert.AreEqual(1, n);
            a.Close();

            var fs = File.OpenRead("output.dat");
            var br = new BinaryReader(fs);

            Assert.AreEqual(0x11, br.ReadInt32());
            Assert.AreEqual(0xFF, br.ReadByte());
            Assert.AreEqual(0xA0, br.ReadByte());
            Assert.AreEqual(0x00, br.ReadByte());
            Assert.AreEqual(0x00, br.ReadByte());

            br.Close();
        }

        [TestMethod]
        public void 複数ブロックの書き出し()
        {
            var a = new Target();
            a.OpenWrite("output.dat");
            var bk = new Block[3];
            bk[0] = new Block { ID = 0x11, A = 0xFF, R = 0xAA, G = 0x00, B = 0x00 };
            bk[1] = new Block { ID = 0x22, A = 0xFF, R = 0x00, G = 0xAA, B = 0x00 };
            bk[2] = new Block { ID = 0x33, A = 0xFF, R = 0x00, G = 0x00, B = 0xAA };
            int n = a.WriteBlock(bk);
            Assert.AreEqual(3, n);
            a.Close();

            var fs = File.OpenRead("output.dat");
            var br = new BinaryReader(fs);

            Assert.AreEqual(0x11, br.ReadInt32());
            br.ReadBytes(4);
            Assert.AreEqual(0x22, br.ReadInt32());
            br.ReadBytes(4);
            Assert.AreEqual(0x33, br.ReadInt32());
            br.Close();
        }
    }
}
