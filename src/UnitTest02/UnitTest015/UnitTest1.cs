using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest015
{
    /// <summary>
    /// 問15
    /// JSON形式でシリアライズ／デシリアライズを行う、以下のメソッドを実装せよ
    /// </summary>

    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Setup()
        {
            System.IO.File.Delete("output.json");
        }
        [TestCleanup]
        public void Cleanup()
        {
            System.IO.File.Delete("output.json");
        }

        [TestMethod]
        public void JSON形式で単一ブロックの読み込み()
        {
            var a = new Target();
            Block b = a.LoadBlock("input.json");

            Assert.AreEqual(100, b.ID);
            Assert.AreEqual("Black Jack", b.Name);
            Assert.AreEqual("崖の上", b.Address);
            Assert.AreEqual(33, b.Age);
        }
        [TestMethod]
        public void JSON形式で配列の読み込み()
        {
            var a = new Target();
            List<Block> lst = a.LoadBlocks("input.json");

            Assert.AreEqual(3, lst.Count);
            Assert.AreEqual(100, lst[0].ID);
            Assert.AreEqual(200, lst[1].ID);
            Assert.AreEqual(300, lst[2].ID);
        }
        [TestMethod]
        public void JSON形式で単一ブロックの書き出し()
        {
            var bk = new Block
            {
                ID = 100,
                Name = "ブラック・ジャック",
                Address = "日本のどこか",
                Age = 33
            };

            var a = new Target();
            a.SaveBlock("output.json", bk);

            var sr = new StreamReader("output.json");
            var jr = new JsonTextReader(sr);
            var js = new JsonSerializer();
            var bk2 = js.Deserialize<Block>(jr);
            jr.Close();

            Assert.AreEqual(100, bk2.ID);
            Assert.AreEqual("ブラック・ジャック", bk2.Name);
            Assert.AreEqual("日本のどこか", bk2.Address);
            Assert.AreEqual(33, bk2.Age);
        }
        [TestMethod]
        public void JSON形式で配列の書き出し()
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
            a.SaveBlocks("output.json", lst);

            var sr = new StreamReader("output.json");
            var jr = new JsonTextReader(sr);
            var js = new JsonSerializer();
            var lst2 = js.Deserialize<List<Block>>(jr);
            jr.Close();

            Assert.AreEqual(3, lst2.Count);
            Assert.AreEqual(100, lst2[0].ID);
            Assert.AreEqual(200, lst2[1].ID);
            Assert.AreEqual(300, lst2[2].ID);
        }

        [TestMethod]
        public void 読み込んだ後に指定IDで検索()
        {
            var a = new Target();
            Block b = a.SearchBlock("input2.json", 200);

            Assert.AreEqual(200, b.ID);
            Assert.AreEqual("ポニョ", b.Name);
        }
        [TestMethod]
        public void 読み込んだ後に名前の一覧を取得()
        {
            var a = new Target();
            List<string> bk2 = a.GetNames("input2.json");

            Assert.AreEqual(3, bk2.Count());
            Assert.AreEqual("Black Jack", bk2[0]);
            Assert.AreEqual("ポニョ", bk2[1]);
            Assert.AreEqual("金さん", bk2[2]);
        }
    }
}
