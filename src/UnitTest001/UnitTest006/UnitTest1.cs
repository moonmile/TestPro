using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest006
{
    /// <summary>
    /// 問6
    /// 配列を操作するいくつかのメソッドを実装せよ
    /// </summary>

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 追加しながら配列を作る()
        {
            var a = new Target();
            a.Append(10);
            a.Append(20);
            a.Append(30);
            Assert.AreEqual(3, a.Count);
            Assert.AreEqual(10, a.At(0));
            Assert.AreEqual(20, a.At(1));
            Assert.AreEqual(30, a.At(2));
        }

        [TestMethod]
        public void 先頭に追加する()
        {
            var a = new Target();
            a.Insert(10);
            a.Insert(20);
            a.Insert(30);
            Assert.AreEqual(3, a.Count);
            Assert.AreEqual(30, a.At(0));
            Assert.AreEqual(20, a.At(1));
            Assert.AreEqual(10, a.At(2));
        }

        [TestMethod]
        public void 合計値を計算する()
        {
            var a = new Target();
            a.Insert(10);
            a.Insert(20);
            a.Insert(30);
            Assert.AreEqual(3, a.Count);
            Assert.AreEqual(60, a.Sum());
        }

        [TestMethod]
        public void 指定した要素を削除する()
        {
            var a = new Target();
            a.Append(10);
            a.Append(20);
            a.Append(30);
            Assert.AreEqual(3, a.Count);
            a.RemoveAt(2);
            Assert.AreEqual(2, a.Count);
            Assert.AreEqual(10, a.At(0));
            Assert.AreEqual(30, a.At(1));
        }

        [TestMethod]
        public void 要素の値を指定して削除する()
        {
            var a = new Target();
            a.Append(10);
            a.Append(20);
            a.Append(30);
            Assert.AreEqual(3, a.Count);
            a.Remove(10);
            Assert.AreEqual(2, a.Count);
            Assert.AreEqual(20, a.At(0));
            Assert.AreEqual(30, a.At(1));
            a.Remove(100);
            Assert.AreEqual(2, a.Count);
        }
        [TestMethod]
        public void 要素をクリアする()
        {
            var a = new Target();
            a.Append(10);
            a.Append(20);
            a.Append(30);
            Assert.AreEqual(3, a.Count);
            a.Clear();
            Assert.AreEqual(0, a.Count);
            a.Append(10);
            a.Append(20);
            Assert.AreEqual(2, a.Count);
        }
    }
}
