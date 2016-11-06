using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace UnitTest011
{
    /// <summary>
    /// 問11
    /// テキストファイルを読み込んで、以下のメソッドを実装せよ
    /// </summary>

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ファイル名を渡す()
        {
            var a = new Target();
            var line = a.GetOne("sample.txt");
            Assert.IsNotNull(line);
            Assert.AreEqual("tokyo", line);
        }
        [TestMethod]
        public void ストリームを渡す()
        {
            var st = new StreamReader("sample.txt");
            var a = new Target( st );
            Assert.AreEqual("tokyo", a.GetLine());
            Assert.AreEqual("oosaka", a.GetLine());
            Assert.AreEqual("sapporo", a.GetLine());
            st.Close();
        }
        [TestMethod]
        public void 文字単位で読み込む()
        {
            var st = new StreamReader("sample.txt");
            var a = new Target(st);
            Assert.AreEqual('t', a.GetChar());
            Assert.AreEqual('o', a.GetChar());
            Assert.AreEqual('k', a.GetChar());
            st.Close();
        }
    }
}
