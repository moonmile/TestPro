using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest004
{
    /// <summary>
    /// 問4
    /// 以下のテストが通るように、文字列の比較と文字列を含んでいるかどうかのメソッドを直せ
    /// </summary>

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 文字列を大文字小文字を無視して比較する()
        {
            var a = new Target();
            Assert.AreEqual(true, a.IsEqual("unit", "unit"));
            Assert.AreEqual(true, a.IsEqual("unit", "UNIT"));
            Assert.AreEqual(false, a.IsEqual("Javascript", "Java"));
            Assert.AreEqual(false, a.IsEqual("Java", "Java"));
        }
        [TestMethod]
        public void 文字列が含まれているか調べる()
        {
            var a = new Target();
            Assert.AreEqual(true, a.IsContain("unit", "unit"));
            Assert.AreEqual(false, a.IsContain("unit", "UNIT"));
            Assert.AreEqual(false, a.IsContain("Javascript", "Java"));
            Assert.AreEqual(false, a.IsContain("Java", ""));
            Assert.AreEqual(true, a.IsContain("Java", "Java"));
        }
    }
}
