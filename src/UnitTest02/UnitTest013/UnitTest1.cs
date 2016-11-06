using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest013
{
    /// <summary>
    /// 問13
    /// バイナリデータをアクセスする、以下のメソッドを実装せよ
    /// </summary>

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
        public void 単一バイトの読み込み()
        {
            var a = new Target();
            a.OpenRead("input.dat");
            Assert.AreEqual<byte>(0x10, a.ReadByte());
            Assert.AreEqual<byte>(0x20, a.ReadByte());
            Assert.AreEqual<byte>(0x30, a.ReadByte());
            a.Close();
        }
        [TestMethod]
        public void 複数バイトの読み込み()
        {
            var a = new Target();
            a.OpenRead("input.dat");
            byte[] data = a.ReadBytes(5);
            Assert.AreEqual<byte>(0x10, data[0]);
            Assert.AreEqual<byte>(0x20, data[1]);
            Assert.AreEqual<byte>(0x30, data[2]);
            data = a.ReadBytes(5);
            Assert.AreEqual<byte>(0x60, data[0]);
            Assert.AreEqual<byte>(0x70, data[1]);
            Assert.AreEqual<byte>(0x80, data[2]);
            a.Close();
        }
        [TestMethod]
        public void 読み込み時にオープンエラー()
        {
            var a = new Target();
            bool b = a.OpenRead("unknown.dat");
            Assert.AreEqual(false, b);
        }

        [TestMethod]
        public void 単一バイトの書き出し()
        {
            var a = new Target();
            a.OpenWrite("output.dat");
            a.WriteByte(0x10);
            a.WriteByte(0x20);
            a.WriteByte(0x30);
            a.WriteByte(0x40);
            a.WriteByte(0x50);
            a.Close();

            var fs = File.OpenRead("output.dat");
            var sr = new System.IO.BinaryReader(fs);
            var data = sr.ReadBytes(5);
            fs.Close();
            Assert.AreEqual<byte>(0x10, data[0]);
            Assert.AreEqual<byte>(0x20, data[1]);
            Assert.AreEqual<byte>(0x30, data[2]);

        }
        [TestMethod]
        public void 複数バイトの書き出し()
        {
            var data = new byte[] { 0x10, 0x20, 0x30, 0x40, 0x50, 0x60, };
            var a = new Target();
            a.OpenWrite("output.dat");
            a.WriteBytes(data);
            a.Close();

            var fs = File.OpenRead("output.dat");
            var sr = new System.IO.BinaryReader(fs);
            var data2 = sr.ReadBytes(5);
            fs.Close();
            Assert.AreEqual<byte>(0x10, data2[0]);
            Assert.AreEqual<byte>(0x20, data2[1]);
            Assert.AreEqual<byte>(0x30, data2[2]);
        }
    }
}
