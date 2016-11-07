using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using System.Collections.Generic;

namespace UnitTest016
{
    /// <summary>
    /// 問16
    /// XML形式でシリアライズ／デシリアライズを行う、以下のメソッドを実装せよ
    /// </summary>

    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Setup()
        {
            System.IO.File.Delete("output.xml");
        }
        [TestCleanup]
        public void Cleanup()
        {
            System.IO.File.Delete("output.xml");
        }

        [TestMethod]
        public void XML形式で単一ブロックの読み込み()
        {
            var a = new Target();
            Block b = a.LoadBlock("input.xml");

            Assert.AreEqual(100, b.ID);
            Assert.AreEqual("Black Jack", b.Name);
            Assert.AreEqual("崖の上", b.Address);
            Assert.AreEqual(33, b.Age);
        }
        [TestMethod]
        public void XML形式で配列の読み込み()
        {
            var a = new Target();
            Blocks lst = a.LoadBlocks("input.xml");

            Assert.AreEqual(3, lst.Count);
            Assert.AreEqual(100, lst[0].ID);
            Assert.AreEqual(200, lst[1].ID);
            Assert.AreEqual(300, lst[2].ID);
        }
        [TestMethod]
        public void XML形式で単一ブロックの書き出し()
        {
            var bk = new Block
            {
                ID = 100,
                Name = "ブラック・ジャック",
                Address = "日本のどこか",
                Age = 33
            };

            var a = new Target();
            a.SaveBlock("output.xml", bk);

            var doc = XDocument.Load("output.xml");
            var el = doc.Root.Element("Block");

            Assert.AreEqual("100", el.Attribute("ID").Value);
            Assert.AreEqual("ブラック・ジャック", el.Element("Name").Value);
            Assert.AreEqual("日本のどこか", el.Element("Address").Value);
            Assert.AreEqual("33", el.Element("Age").Value);
        }
        [TestMethod]
        public void XML形式で配列の書き出し()
        {
            var lst = new Block[]
            {
                new Block
                {
                    ID = 100,
                    Name = "ブラック・ジャック",
                    Address = "日本のどこか",
                    Age = 33
                },
                new Block { ID = 200 },
                new Block { ID = 300 },
            };

            var a = new Target();
            a.SaveBlocks("output.xml", lst);

            var doc = XDocument.Load("output.xml");
            var els = doc.Root.Elements("Block");

            var el = els.GetEnumerator();
            el.MoveNext();
            Assert.AreEqual("100", el.Current.Attribute("ID").Value);
            el.MoveNext();
            Assert.AreEqual("200", el.Current.Attribute("ID").Value);
            el.MoveNext();
            Assert.AreEqual("300", el.Current.Attribute("ID").Value);
        }

        [TestMethod]
        public void 読み込んだ後に指定IDで検索()
        {
            var a = new Target();
            Block b = a.SearchBlock("input2.xml", 200);

            Assert.AreEqual(200, b.ID);
            Assert.AreEqual("ポニョ", b.Name);
        }
        [TestMethod]
        public void 読み込んだ後に名前の一覧を取得()
        {

            var a = new Target();
            List<string> bk2 = a.GetNames("input2.json");

            Assert.AreEqual(3, bk2.Count);
            Assert.AreEqual("Black Jack", bk2[0]);
            Assert.AreEqual("ポニョ", bk2[1]);
            Assert.AreEqual("金さん", bk2[2]);
        }
    }
}
