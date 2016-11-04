using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTest007
{
    /// <summary>
    /// 問7
    /// 配列を探索するいくつかのメソッドを実装せよ
    /// </summary>

    [TestClass]
    public class UnitTest1
    {
        List<string> lst;

        [TestInitialize]
        public void Setup()
        {
            lst = new List<string>();
            lst.Add("tokyo");
            lst.Add("oosaka");
            lst.Add("sapporo");
        }

        [TestMethod]
        public void 要素を指定してインデックスを返す()
        {
            var a = new Target();
            a.Items = lst;
            Assert.AreEqual(1, a.Search("oosaka"));
            Assert.AreEqual(-1, a.Search("okinawa"));
        }
        [TestMethod]
        public void 要素の一部分を探索()
        {
            var a = new Target();
            a.Items = lst;
            var result = a.Include("tokyo");
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("tokyo", result[0]);

        }
        [TestMethod]
        public void 要素の一部分を探索2()
        {
            var a = new Target();
            a.Items = lst;
            var result = a.Include("k");
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("tokyo", result[0]);
            Assert.AreEqual("oosaka", result[1]);
        }
        [TestMethod]
        public void 要素が見つからない場合()
        {
            var a = new Target();
            a.Items = lst;
            var result = a.Include("unknown");
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }
    }
}
