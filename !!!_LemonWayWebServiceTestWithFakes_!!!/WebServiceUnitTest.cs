
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonWayBusinessLogicLayer;
using LemonWayBusinessLogicLayer.Fakes;


namespace LemonWayWebServiceTest
{
    [TestClass]
    public class WebServiceUnitTest
    {
        private static TestContext context;

        [ClassInitialize()]
        public static void InitTestSuite(TestContext testContext)
        {
            context = testContext;           
        }

        [TestInitialize()]
        public void TestInitialize(){}

        #region Test with Microsoft Fakes

        [TestMethod]
        public void _fakeXmlFileToJsonTest()
        {
            string xmlExampleFoundOnInternet = @"<?xml version=""1.0""?><AUTHRESP><RESPONSE>3</RESPONSE><AUTHPARM1>S9801231</AUTHPARM1><BALLOT></BALLOT></AUTHRESP>";

            IXmlFileService xfs =
                 new StubIXmlFileService()
                 {
                     GetXmlFromFilePathString = (path) => { return xmlExampleFoundOnInternet; }
                 };

            string FACTOR = xfs.getXmlFromFilePath(@"c:\test.xml");

            IXmlToJsonService _xjs = new XmlToJsonService();
            string jsonFactor = _xjs.convertXmlToJson(FACTOR);
            bool actual = HelperService.IsValidJson(jsonFactor);
            Assert.IsTrue(actual, "Wrong result from XmlToJson function");
        }

        #endregion Test with Microsoft Fakes

        #region Fibonacci Tests with 1 to 8 integer parameters

        [TestMethod()]
        public void fibonacciTest_with_arg_01_returns_1()
        {
            const int FACTOR = 1;
            string EXPECTED = HelperService.GetOnePairJson("1");

            IFibonacciService _fs = new FibonacciService();
            long a = _fs.getFibonacci(FACTOR);
            string actual = HelperService.GetOnePairJson(a.ToString());
            Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function with in range parameter.");
        }

        [TestMethod()]
        public void fibonacciTest_with_arg_02_returns_1()
        {
            const int FACTOR = 2;
            string EXPECTED = HelperService.GetOnePairJson("1");

            IFibonacciService _fs = new FibonacciService();
            long a = _fs.getFibonacci(FACTOR);
            string actual = HelperService.GetOnePairJson(a.ToString());
            Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function with in range parameter.");
        }

        [TestMethod()]
        public void fibonacciTest_with_arg_03_returns_2()
        {
            const int FACTOR = 3;
            string EXPECTED = HelperService.GetOnePairJson("2");

            IFibonacciService _fs = new FibonacciService();
            long a = _fs.getFibonacci(FACTOR);
            string actual = HelperService.GetOnePairJson(a.ToString());
            Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function with in range parameter.");
        }

        [TestMethod()]
        public void fibonacciTest_with_arg_04_returns_3()
        {
            const int FACTOR = 4;
            string EXPECTED = HelperService.GetOnePairJson("3");

            IFibonacciService _fs = new FibonacciService();
            long a = _fs.getFibonacci(FACTOR);
            string actual = HelperService.GetOnePairJson(a.ToString());
            Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function with in range parameter.");
        }

        [TestMethod()]
        public void fibonacciTest_with_arg_05_returns_5()
        {
            const int FACTOR = 5;
            string EXPECTED = HelperService.GetOnePairJson("5");

            IFibonacciService _fs = new FibonacciService();
            long a = _fs.getFibonacci(FACTOR);
            string actual = HelperService.GetOnePairJson(a.ToString());
            Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function with in range parameter.");
        }

        [TestMethod()]
        public void fibonacciTest_with_arg_06_returns_8()
        {
            const int FACTOR = 6;
            string EXPECTED = HelperService.GetOnePairJson("8");

            IFibonacciService _fs = new FibonacciService();
            long a = _fs.getFibonacci(FACTOR);
            string actual = HelperService.GetOnePairJson(a.ToString());
            Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function with in range parameter.");
        }

        [TestMethod()]
        public void fibonacciTest_with_arg_07_returns_13()
        {
            const int FACTOR = 7;
            string EXPECTED = HelperService.GetOnePairJson("13");

            IFibonacciService _fs = new FibonacciService();
            long a = _fs.getFibonacci(FACTOR);
            string actual = HelperService.GetOnePairJson(a.ToString());
            Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function with in range parameter.");
        }

        [TestMethod()]
        public void fibonacciTest_with_arg_08_returns_21()
        {
            const int FACTOR = 8;
            string EXPECTED = HelperService.GetOnePairJson("21");

            IFibonacciService _fs = new FibonacciService();
            long a = _fs.getFibonacci(FACTOR);
            string actual = HelperService.GetOnePairJson(a.ToString());
            Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function with in range parameter.");
        }

        #endregion Fibonacci tests with 1 to 8 integer parameters

        #region Fibonacci tests with 51 to 59 integer parameters

        [TestMethod()]
        public void fibonacciTest_with_arg_51_returns_20365011074()
        {
            const int FACTOR = 51;
            string EXPECTED = HelperService.GetOnePairJson("20365011074");

            IFibonacciService _fs = new FibonacciService();
            long a = _fs.getFibonacci(FACTOR);
            string actual = HelperService.GetOnePairJson(a.ToString());
            Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function with in range parameter.");
        }

        [TestMethod()]
        public void fibonacciTest_with_arg_52_returns_32951280099()
        {
            const int FACTOR = 52;
            string EXPECTED = HelperService.GetOnePairJson("32951280099");

            IFibonacciService _fs = new FibonacciService();
            long a = _fs.getFibonacci(FACTOR);
            string actual = HelperService.GetOnePairJson(a.ToString());
            Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function with in range parameter.");
        }

        [TestMethod()]
        public void fibonacciTest_with_arg_53_returns_53316291173()
        {
            const int FACTOR = 53;
            string EXPECTED = HelperService.GetOnePairJson("53316291173");

            IFibonacciService _fs = new FibonacciService();
            long a = _fs.getFibonacci(FACTOR);
            string actual = HelperService.GetOnePairJson(a.ToString());
            Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function with in range parameter.");
        }

        [TestMethod()]
        public void fibonacciTest_with_arg_54_returns_86267571272()
        {
            const int FACTOR = 54;
            string EXPECTED = HelperService.GetOnePairJson("86267571272");

            IFibonacciService _fs = new FibonacciService();
            long a = _fs.getFibonacci(FACTOR);
            string actual = HelperService.GetOnePairJson(a.ToString());
            Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function with in range parameter.");
        }

        [TestMethod()]
        public void fibonacciTest_with_arg_55_returns_139583862445()
        {
            const int FACTOR = 55;
            string EXPECTED = HelperService.GetOnePairJson("139583862445");

            IFibonacciService _fs = new FibonacciService();
            long a = _fs.getFibonacci(FACTOR);
            string actual = HelperService.GetOnePairJson(a.ToString());
            Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function with in range parameter.");
        }

        [TestMethod()]
        public void fibonacciTest_with_arg_56_returns_225851433717()
        {
            const int FACTOR = 56;
            string EXPECTED = HelperService.GetOnePairJson("225851433717");

            IFibonacciService _fs = new FibonacciService();
            long a = _fs.getFibonacci(FACTOR);
            string actual = HelperService.GetOnePairJson(a.ToString());
            Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function with in range parameter.");
        }

        [TestMethod()]
        public void fibonacciTest_with_arg_57_returns_365435296162()
        {
            const int FACTOR = 57;
            string EXPECTED = HelperService.GetOnePairJson("365435296162");

            IFibonacciService _fs = new FibonacciService();
            long a = _fs.getFibonacci(FACTOR);
            string actual = HelperService.GetOnePairJson(a.ToString());
            Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function with in range parameter.");
        }

        [TestMethod()]
        public void fibonacciTest_with_arg_58_returns_591286729879()
        {
            const int FACTOR = 58;
            string EXPECTED = HelperService.GetOnePairJson("591286729879");

            IFibonacciService _fs = new FibonacciService();
            long a = _fs.getFibonacci(FACTOR);
            string actual = HelperService.GetOnePairJson(a.ToString());
            Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function with in range parameter.");
        }

        [TestMethod()]
        public void fibonacciTest_with_arg_59_returns_956722026041()
        {
            const int FACTOR = 59;
            string EXPECTED = HelperService.GetOnePairJson("956722026041");

            IFibonacciService _fs = new FibonacciService();
            long a = _fs.getFibonacci(FACTOR);
            string actual = HelperService.GetOnePairJson(a.ToString());
            Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function with in range parameter.");
        }

        #endregion Fibonacci tests with 51 to 59 integer parameters

        #region Fibonacci tests with parameters out of range

        [TestMethod]
        public void fibonacciNegativeInputTest()
        {
            const int FACTOR = -3;
            string errorCode = HelperService.GetOnePairJson("-1");
            string EXPECTED = errorCode;

            IFibonacciService _fs = new FibonacciService();
            long a = _fs.getFibonacci(FACTOR);
            string actual = HelperService.GetOnePairJson(a.ToString());
            Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function with out of range parameter.");
        }

        [TestMethod]
        public void fibonacciZeroAsInputTest()
        {
            const int FACTOR = 0;
            string errorCode = HelperService.GetOnePairJson("-1");
            string EXPECTED = errorCode;

            IFibonacciService _fs = new FibonacciService();
            long a = _fs.getFibonacci(FACTOR);
            string actual = HelperService.GetOnePairJson(a.ToString());
            Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function with out of range parameter.");
        }

        [TestMethod]
        public void fibonacciMoreThanHundredInputTest()
        {
            const int FACTOR = 104;
            string errorCode = HelperService.GetOnePairJson("-1");
            string EXPECTED = errorCode;

            IFibonacciService _fs = new FibonacciService();
            long a = _fs.getFibonacci(FACTOR);
            string actual = HelperService.GetOnePairJson(a.ToString());
            Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function with out of range parameter.");
        }

        #endregion Fibonacci tests with parameters out of range

        #region XmlToJson tests

        [TestMethod]
        public void XmlBadToJsonTest()
        {
            const string FACTOR = "<foo>hello</bar>";
            const string EXPECTED = "Bad Xml format";

            IXmlToJsonService _xjs = new XmlToJsonService();
            string actual = _xjs.convertXmlToJson(FACTOR);
            Assert.AreEqual(EXPECTED, actual, "Wrong result from XmlToJson function");
        }

        [TestMethod]
        public void xmlToJsonTest()
        {
            const string FACTOR = "<foo>bar</foo>";
            string EXPECTED = HelperService.GetOnePairJson("foo", "bar");

            IXmlToJsonService _xjs = new XmlToJsonService();
            string actual = _xjs.convertXmlToJson(FACTOR);
            Assert.AreEqual(EXPECTED, actual, "Wrong result from XmlToJson function");
        }
 
    #endregion XmlToJson tests

    }
}
