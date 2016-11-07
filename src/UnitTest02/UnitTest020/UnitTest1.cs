using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;

namespace UnitTest020
{
    /// <summary>
    /// 問20
    /// ファイル／フォルダ検索用のクラスを駆使して、以下のメソッドを実装せよ
    /// </summary>

    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Setup()
        {
            if (!System.IO.Directory.Exists("test"))
            {
                Directory.CreateDirectory("test");
                File.WriteAllText("test\\sample1.txt", "sample");
                File.WriteAllText("test\\sample2.txt", "sample");
                File.WriteAllText("test\\sample3.xml", "sample");
                File.WriteAllText("test\\sample4.dat", "sample");
            }
        }


        [TestMethod]
        public void ファイルの存在チェック()
        {
            var a = new Target();
            bool b = a.FileExists("test", "sample2.txt");
            Assert.AreEqual(true, b);
        }
        [TestMethod]
        public void ファイルの存在チェック2()
        {
            var a = new Target();
            bool b = a.FileExists("test", "unknown.txt");
            Assert.AreEqual(false, b);
        }
        [TestMethod]
        public void フォルダの存在チェック()
        {
            var a = new Target();
            bool b = a.DirExists("test");
            Assert.AreEqual(true, b);
        }
        [TestMethod]
        public void フォルダの中身を検索()
        {
            var a = new Target();
            List<string> files = a.GetFiles("test", "*.*");

            Assert.AreEqual(4, files.Count);
            Assert.AreEqual(true, files.Contains("sample1.txt"));
            Assert.AreEqual(true, files.Contains("sample2.txt"));
            Assert.AreEqual(true, files.Contains("sample3.xml"));
            Assert.AreEqual(true, files.Contains("sample4.dat"));
        }
        [TestMethod]
        public void フォルダ内の指定拡張子ファイルをリスト化()
        {
            var a = new Target();
            List<string> files = a.GetFiles("test", "*.xml");

            Assert.AreEqual(4, files.Count);
            Assert.AreEqual(true, files.Contains("sample3.xml"));
        }
    }
}
