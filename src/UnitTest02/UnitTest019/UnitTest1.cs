using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace UnitTest019
{
    /// <summary>
    /// 問19
    /// メモリストリーム(System.IO.MemoryStream)を利用して、以下のメソッドを実装せよ
    /// </summary>

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void バイナリデータの作成()
        {
            var data = new byte[16];
            var mem = new MemoryStream( data );
            var a = new Target(mem);

            a.Init(0xFF);
            var buf = a.ToBytes();
            Assert.AreEqual(0xFF, buf[0]);
            Assert.AreEqual(0xFF, buf[15]);
        }

        [TestMethod]
        public void バイナリデータの作成2()
        {
            var data = new byte[16];
            data[0] = 0xFF;
            data[15] = 0xFF;
            var mem = new MemoryStream(data);
            var a = new Target(mem);

            a.Clear();
            var buf = a.ToBytes();
            Assert.AreEqual(0x00, buf[0]);
            Assert.AreEqual(0x00, buf[15]);
        }

        [TestMethod]
        public void バイナリデータの作成3()
        {
            var data = new byte[16];
            var mem = new MemoryStream(data);
            var a = new Target(mem);

            var pat = new byte[4] { 0x01, 0x02, 0x03, 0x04 };

            a.Init(pat);
            var buf = a.ToBytes();
            Assert.AreEqual(0x01, buf[0]);
            Assert.AreEqual(0x02, buf[1]);
            Assert.AreEqual(0x03, buf[2]);
            Assert.AreEqual(0x04, buf[3]);
            Assert.AreEqual(0x01, buf[4]);
            Assert.AreEqual(0x02, buf[5]);
            Assert.AreEqual(0x03, buf[6]);
        }

        [TestMethod]
        public void バイナリデータの作成4()
        {
            var data = new byte[16];
            var mem = new MemoryStream(data);
            var a = new Target(mem);

            a.Init(0xFF);
            var buf = a.ToBytes();
            Assert.AreEqual(0xFF, buf[0]);
            Assert.AreEqual(0xFF, buf[15]);
            // 設定位置が先頭に戻ること
            a.Clear();
            buf = a.ToBytes();
            Assert.AreEqual(0x00, buf[0]);
            Assert.AreEqual(0x00, buf[15]);
        }
    }
}
