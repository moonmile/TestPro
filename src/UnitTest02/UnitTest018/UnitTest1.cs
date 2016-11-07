using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest018
{
    
    /// <summary>
    /// 問18
    /// 文字列ストリームを利用して、以下のメソッドを実装せよ
    /// </summary>

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 文字列からJSONオブジェクトを作成する()
        {
            string json = @"
{
  ""ID"": 100,
  ""Name"": ""Black Jack"",
  ""Address"": ""崖の上"",
  ""Age"":  33
}";
            var a = new Target();
            Block b = a.LoadJson(json);

            Assert.AreEqual(100, b.ID);
            Assert.AreEqual("Black Jack", b.Name);
            Assert.AreEqual("崖の上", b.Address);
            Assert.AreEqual(33, b);
        }

        [TestMethod]
        public void 文字列からXMLオブジェクトを作成する()
        {
            string xml = @"
<Root>
    <Block ID='100'>
        <Name>Black Jack</Name>
        <Address>崖の上</Address>
        <Age>33</Age>
    </Block>
</Root>
";

            var a = new Target();
            Block b = a.LoadXml(xml);

            Assert.AreEqual(100, b.ID);
            Assert.AreEqual("Black Jack", b.Name);
            Assert.AreEqual("崖の上", b.Address);
            Assert.AreEqual(33, b);
        }

    }
}
