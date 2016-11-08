using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest001
{
    /// <summary>
    /// 問1
    /// 以下の四則演算が通るように、Target クラスを直せ
    /// </summary>

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 加算する()
        {
            var a = new Target();
            Assert.AreEqual(5, a.Add(2, 3));
            Assert.AreEqual(3, a.Add(0, 3));
            Assert.AreEqual(2, a.Add(2, 0));
        }

        [TestMethod]
        public void 掛け算する()
        {
            var a = new Target();
            Assert.AreEqual(6, a.Mul(2, 3));
            Assert.AreEqual(0, a.Mul(0, 3));
            Assert.AreEqual(0, a.Mul(2, 0));
        }
    }
}
