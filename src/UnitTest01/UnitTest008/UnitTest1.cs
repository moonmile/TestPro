using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest008
{
    /// <summary>
    /// 問8
    /// 条件文（ifやswitchなど）を使って以下のメソッドを実装せよ
    /// </summary>


    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 色を指定する()
        {
            var a = new Target();
            a.SetColor("Red");
            Assert.AreEqual(a.R, 255);
            Assert.AreEqual(a.G, 0);
            Assert.AreEqual(a.B, 0);

            a.SetColor("Green");
            Assert.AreEqual(a.R, 0);
            Assert.AreEqual(a.G, 255);
            Assert.AreEqual(a.B, 0);

            a.SetColor("Blue");
            Assert.AreEqual(a.R, 0);
            Assert.AreEqual(a.G, 0);
            Assert.AreEqual(a.B, 255);
        }

        [TestMethod]
        public void 色を指定する2()
        {
            var a = new Target();
            a.SetColor("白");
            Assert.AreEqual(a.R, 255);
            Assert.AreEqual(a.G, 255);
            Assert.AreEqual(a.B, 255);

            a.SetColor("黒");
            Assert.AreEqual(a.R, 0);
            Assert.AreEqual(a.G, 0);
            Assert.AreEqual(a.B, 0);

            a.SetColor("灰色");
            Assert.AreEqual(a.R, 100);
            Assert.AreEqual(a.G, 100);
            Assert.AreEqual(a.B, 100);

        }
        [TestMethod]
        public void 色を変更する()
        {
            var a = new Target();
            a.SetColor("灰色");
            Assert.AreEqual(a.R, 100);
            Assert.AreEqual(a.G, 100);
            Assert.AreEqual(a.B, 100);

            a.ToLight(20);
            Assert.AreEqual(a.R, 120);
            Assert.AreEqual(a.G, 120);
            Assert.AreEqual(a.B, 120);

            a.RedOnly();
            Assert.AreEqual(a.R, 120);
            Assert.AreEqual(a.G, 0);
            Assert.AreEqual(a.B, 0);
        }
    }
}
