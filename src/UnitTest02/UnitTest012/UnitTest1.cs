using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace UnitTest012
{
    /// <summary>
    /// 問12
    /// テキストファイルに書き出す処理を、以下のメソッドを実装せよ
    /// </summary>

    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]
        public void Setup()
        {
            System.IO.File.Delete("sample.txt");
        }
        [TestCleanup]
        public void Cleanup()
        {
            System.IO.File.Delete("sample.txt");
        }

        [TestMethod]
        public void ファイル名を渡して書き出し()
        {
            var a = new Target("sample.txt");

            a.WriteOne("tokyo");

            var st = new StreamReader("sample.txt");
            var line = st.ReadLine();
            st.Close();
            Assert.AreEqual("tokyo", line);
        }

        [TestMethod]
        public void ストリームを渡して書き出し()
        {
            var st = new StreamWriter("sample.txt");
            var a = new Target( st );
            a.WriteLine("tokyo");
            a.WriteLine("oosaka");
            a.WriteLine("sapporo");
            st.Close();

            var sr = new StreamReader("sample.txt");
            Assert.AreEqual("tokyo", sr.ReadLine());
            Assert.AreEqual("oosaka", sr.ReadLine());
            Assert.AreEqual("sapporo", sr.ReadLine());
            sr.Close();
        }
        [TestMethod]
        public void 文字単位で書き出し()
        {
            var st = new StreamWriter("sample.txt");
            var a = new Target(st);
            a.WriteChar('o');
            a.WriteChar('n');
            a.WriteChar('e');
            st.Close();

            var sr = new StreamReader("sample.txt");
            Assert.AreEqual("one", sr.ReadLine());
            sr.Close();
        }
    }
}
