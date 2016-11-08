using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest005
{
    /// <summary>
    /// 問5
    /// 配列にアクセスするいくつかのメソッドを実装せよ
    /// </summary>

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 配列にアクセスする()
        {
            var a = new Target();
            a.Items = new int [] { 10, 20, 30 };

            Assert.AreEqual(3, a.Count);
            Assert.AreEqual(20, a.GetAt(1));
        }

        [TestMethod]
        public void 配列外のアクセスを許容する()
        {
            var a = new Target();
            a.Items = new int[] { 10, 20, 30 };

            Assert.AreEqual(3, a.Count);
            Assert.AreEqual(0, a.GetAt(100));
        }

        [TestMethod]
        public void 先頭の要素を取得する()
        {
            var a = new Target();
            a.Items = new int[] { 10, 20, 30 };

            Assert.AreEqual(3, a.Count);
            Assert.AreEqual(10, a.First);
        }

        [TestMethod]
        public void 末尾の要素を取得する()
        {
            var a = new Target();
            a.Items = new int[] { 10, 20, 30 };

            Assert.AreEqual(3, a.Count);
            Assert.AreEqual(30, a.Last);
        }
    }
}
