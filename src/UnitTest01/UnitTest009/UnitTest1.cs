using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTest009
{
    /// <summary>
    /// 問9
    /// 辞書クラス（Dictonary）を使って以下のメソッドを実装せよ
    /// </summary>

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void キーと値を設定する()
        {
            var a = new Target();
            a.Set("key1", "value1");
            a.Set("key2", "value2");
            Assert.AreEqual(2, a.Count);
        }

        [TestMethod]
        public void キーを指定して値を取り出す()
        {
            var a = new Target();
            a.Set("key1", "value1");
            a.Set("key2", "value2");
            a.Set("key3", "value3");
            Assert.AreEqual(3, a.Count);
            Assert.AreEqual("value2", a.GetValue("key2"));
        }
        [TestMethod]
        public void キーを指定して値を取り出す2()
        {
            var a = new Target();
            a.Set("key1", "value1");
            a.Set("key2", "value2");
            a.Set("key3", "value3");
            Assert.AreEqual(3, a.Count);
            Assert.AreEqual("", a.GetValue("unknown"));
        }

        [TestMethod]
        public void 値の一覧を取り出す()
        {
            var a = new Target();
            a.Set("key1", "value1");
            a.Set("key2", "value2");
            a.Set("key3", "value3");
            Assert.AreEqual(3, a.Count);
            List<string> values = a.Values;
            Assert.IsNotNull(values);
            Assert.AreEqual(3, values.Count);
            Assert.AreEqual(true, values.Contains("value1"));
            Assert.AreEqual(true, values.Contains("value2"));
            Assert.AreEqual(true, values.Contains("value3"));
        }
        [TestMethod]
        public void 値の一覧を取り出す2()
        {
            var a = new Target();
            Assert.AreEqual(0, a.Count);
            List<string> values = a.Values;
            Assert.IsNotNull(values);
            Assert.AreEqual(0, values.Count);
        }
    }
}
