using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest002
{
    /// <summary>
    /// 問2
    /// 以下の文字列操作が通るように、Target クラスを直せ
    /// </summary>

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 文字列をつなげる()
        {
            var a = new Target();
            Assert.AreEqual("unittest", a.Add("unit", "test"));
            Assert.AreEqual("unit", a.Add("unit", ""));
            Assert.AreEqual("unit", a.Add("", "unit"));
        }
        [TestMethod]
        public void 先頭から指定文字数だけ取得する()
        {
            var a = new Target();
            Assert.AreEqual("unit",     a.Left("unittest", 4));
            Assert.AreEqual("",         a.Left("unittest", 0));
            Assert.AreEqual("unittest", a.Left("unittest", 100));
        }
        [TestMethod]
        public void 末尾から指定文字数だけ取得する()
        {
            var a = new Target();
            Assert.AreEqual("test",     a.Right("unittest", 4));
            Assert.AreEqual("",         a.Right("unittest", 0));
            Assert.AreEqual("unittest", a.Right("unittest", 100));
        }
    }
}
