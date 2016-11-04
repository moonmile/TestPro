using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest010
{
    /// <summary>
    /// 問10
    /// リストクラス（List）を使って以下のメソッドを実装せよ
    /// </summary>

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 値を設定する()
        {
            var a = new Target();
            a.Add("apple");
            a.Add("blue");
            a.Add("club");
            Assert.AreEqual(3, a.Count);
        }
        [TestMethod]
        public void 先頭から要素を取り出す()
        {
            var a = new Target();
            a.Add("apple");
            a.Add("blue");
            a.Add("club");
            Assert.AreEqual(3, a.Count);
            Assert.AreEqual("apple", a.Pop());
            Assert.AreEqual(2, a.Count);
        }
        [TestMethod]
        public void 先頭から要素を取り出す2()
        {
            var a = new Target();
            Assert.AreEqual(0, a.Count);
            Assert.AreEqual("", a.Pop());
            Assert.AreEqual(0, a.Count);
        }
        [TestMethod]
        public void ソートする()
        {
            var a = new Target();
            a.Add("blue");
            a.Add("apple");
            a.Add("club");
            Assert.AreEqual(3, a.Count);
            a.Sort();
            Assert.AreEqual("apple", a.Pop());
        }
        [TestMethod]
        public void 逆順でソートする()
        {
            var a = new Target();
            a.Add("(2) blue");
            a.Add("(3) apple");
            a.Add("(1) club");
            Assert.AreEqual(3, a.Count);
            a.Reverse();
            Assert.AreEqual("club", a.Pop());
        }
    }
}
