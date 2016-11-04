using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest003
{
    /// <summary>
    /// 問3
    /// 以下のテストが通るように Target クラスを比較演算子を使って直せ
    /// </summary>

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 最大値を取得する()
        {
            var a = new Target();
            Assert.AreEqual(3, a.Max(2, 3));
            Assert.AreEqual(3, a.Max(0, 3));
            Assert.AreEqual(2, a.Max(2, 0));
        }
        [TestMethod]
        public void 最小値を取得する()
        {
            var a = new Target();
            Assert.AreEqual(2, a.Min(2, 3));
            Assert.AreEqual(0, a.Min(0, 3));
            Assert.AreEqual(0, a.Min(2, 0));
        }
    }
}
