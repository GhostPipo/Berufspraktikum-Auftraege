using Dictionari;
namespace DictionaryTest
{
    [TestClass]
    public sealed class Dictionarytests
    {
        [TestMethod]
        public void Dictionary_CreateDictionary_AreEqual_Nr1()
        {
            //arrange
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            Dictionaries obj1 = new Dictionaries();
            Dictionary<string, List<string>> dictnew = obj1.CreateDictionary();
            dict["Döner"] = new List<string> { "Brot", "Salat", "Fleisch", "Zwiebel" };
            dict["Pizza"] = new List<string> { "Teig", "Fleisch", "Käse", "Sosse" };
            dict["Lasagne"] = new List<string> { "Sosse", "Teig", "Fleisch", "Zwiebel" };
            string expectedResult = "KEY: BROT; VALUE: Döner\r\nKEY: SALAT; VALUE: Döner\r\nKEY: FLEISCH; VALUE: Döner, Pizza, Lasagne\r\nKEY: ZWIEBEL; VALUE: Döner, Pizza, Lasagne\r\nKEY: TEIG; VALUE: Pizza, Lasagne\r\nKEY: KÄSE; VALUE: Pizza\r\nKEY: SOSSE; VALUE: Pizza, Lasagne";

            //act
            string var1 = obj1.CreateDictionary().ToString();
            //assert
            expectedResult.SequenceEqual(var1);
        }
        [TestMethod]
        public void Dictionary_CreateDictionary_AreEqual_Nr2()
        {
            //arrange
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            Dictionaries obj1 = new Dictionaries();
            Dictionary<string, List<string>> dictnew = obj1.CreateDictionary();
            dict["Döner"] = new List<string> { "Brot", "Salat", "Fleisch", "Zwiebel" };
            dict["Pizza"] = new List<string> { "Teig", "Fleisch", "Käse", "Sosse", "zwiebel" };
            dict["Lasagne"] = new List<string> { "Sosse", "Teig", "Fleisch", "Zwiebel" };
            string expectedResult = "KEY: BROT; VALUE: Döner\r\nKEY: SALAT; VALUE: Döner\r\nKEY: FLEISCH; VALUE: Döner, Pizza, Lasagne\r\nKEY: ZWIEBEL; VALUE: Döner, Pizza, Lasagne\r\nKEY: TEIG; VALUE: Pizza, Lasagne\r\nKEY: KÄSE; VALUE: Pizza\r\nKEY: SOSSE; VALUE: Pizza, Lasagne";

            //act
            string var1 = obj1.CreateDictionary().ToString();
            //assert
            expectedResult.SequenceEqual(var1);
        }
        [TestMethod]
        public void Dictionary_CreateDictionary_AreEqual_Nr3()
        {
            //arrange
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            Dictionaries obj1 = new Dictionaries();
            Dictionary<string, List<string>> dictnew = obj1.CreateDictionary();
            dict["Döner"] = new List<string> { "Brot", "Salat", "Fleisch", "Zwiebel" };
            dict["Pizza"] = new List<string> { "Teig", "Fleisch", "Käse", "Sosse" };
            dict["Lasagne"] = new List<string> { "Sosse", "Teig", "Fleisch", "Zwiebel" };
            string expectedResult = "KEY: Brot; VALUE: Döner\r\nKEY: Salat; VALUE: Döner\r\nKEY: Fleisch; VALUE: Döner, Pizza, Lasagne\r\nKEY: Zwiebel; VALUE: Döner, Lasagne\r\nKEY: Teig; VALUE: Pizza, Lasagne\r\nKEY: Käse; VALUE: Pizza\r\nKEY: Sosse; VALUE: Pizza, Lasagne";

            //act
            string var1 = obj1.CreateDictionary().ToString();
            //assert
            expectedResult.SequenceEqual(var1);
        }
        //AreNotEqual
        [TestMethod]
        public void Dictionary_CreateDictionary_AreNotEqual_Nr1()
        {
            //arrange
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            Dictionaries obj1 = new Dictionaries();
            Dictionary<string, List<string>> dictnew = obj1.CreateDictionary();
            dict["Döner"] = new List<string> { "Brot", "Salat", "Fleisch", "Zwiebel" };
            dict["Pizza"] = new List<string> { "Teig", "Fleisch", "Käse", "Sosse" };
            dict["Lasagne"] = new List<string> { "Sosse", "Teig", "Fleisch", "Zwiebel" };
            string expectedResult = "KEY: Brot; VALUE: Döner\r\nKEY: Salat; VALUE: Döner\r\nKEY: Fleisch; VALUE: Döner, Pizza, Lasagne\r\nKEY: Zwiebel; VALUE: Döner, Lasagne\r\nKEY: Teig; VALUE: Pizza, Lasagne\r\nKEY: Käse; VALUE: Pizza\r\nKEY: Sosse; VALUE: Pizza, Lasagne";

            //act
            string var1 = obj1.CreateDictionary().ToString();
            //assert
            Assert.AreNotEqual(expectedResult, var1);
        }
        [TestMethod]
        public void Dictionary_CreateDictionary_AreNotEqual_Nr2()
        {
            //arrange
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            Dictionaries obj1 = new Dictionaries();
            Dictionary<string, List<string>> dictnew = obj1.CreateDictionary();
            dict["Döner"] = new List<string> { "Brot", "Salat", "Fleisch", "Zwiebel" };
            dict["Pizza"] = new List<string> { "Teig", "Fleisch", "Käse", "Sosse" };
            dict["Lasagne"] = new List<string> { "Sosse", "Teig", "Fleisch", "Zwiebel" };
            string expectedResult = "KEY: Brot; VALUE: Döner\r\nKEY: Salat; VALUE: Döner\r\nKEY: Fleisch; VALUE: Döner, Pizza, Lasagne\r\nKEY: Zwiebel; VALUE: Döner, Lasagne\r\nKEY: Teig; VALUE: Pizza, Lasagne\r\nKEY: Käse; VALUE: Pizza\r\nKEY: Sosse; VALUE: Pizza, Lasagne";

            //act
            string var1 = obj1.CreateDictionary().ToString();
            //assert
            Assert.AreNotEqual(expectedResult, var1);
        }
        [TestMethod]
        public void Dictionary_CreateDictionary_AreNotEqual_Nr3()
        {
            //arrange
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            Dictionaries obj1 = new Dictionaries();
            Dictionary<string, List<string>> dictnew = obj1.CreateDictionary();
            dict["Döner"] = new List<string> { "Brot", "Salat", "Fleisch", "Zwiebel" };
            dict["Pizza"] = new List<string> { "Teig", "Fleisch", "Käse", "Sosse" };
            dict["Lasagne"] = new List<string> { "Sosse", "Teig", "Fleisch", "Zwiebel" };
            string expectedResult = "KEY: Brot; VALUE: Döner\r\nKEY: Salat; VALUE: Döner\r\nKEY: Fleisch; VALUE: Döner, Pizza, Lasagne\r\nKEY: Zwiebel; VALUE: Döner, Lasagne\r\nKEY: Teig; VALUE: Pizza, Lasagne\r\nKEY: Käse; VALUE: Pizza\r\nKEY: Sosse; VALUE: Pizza, Lasagne";

            //act
            string var1 = obj1.CreateDictionary().ToString();
            //assert
            Assert.AreNotEqual(expectedResult, var1);
        }
    }
}
