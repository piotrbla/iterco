using icsc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParserTestProject
{
    
    
    /// <summary>
    ///This is a test class for MainParserTest and is intended
    ///to contain all MainParserTest Unit Tests
    ///</summary>
    [TestClass]
    public class MainParserTest
    {
        public TestContext TestContext { get; set; }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion
        
        [TestMethod]public void MainParserConstructorTest()
        {
            var target = new MainParser();
            Assert.IsNotNull(target);
        }

        [TestMethod]
        public void EmptyProgramCodeParseTest()
        {
            var originalCode = string.Empty;
            MainParser.OneFileCodeModification(originalCode);
            var nonModifiedCode = MainParser.OneFileCodeModification(originalCode);
            Assert.AreEqual(nonModifiedCode, originalCode);
        }

        [TestMethod]
        public void SimpleProgramCodeParseTest()
        {
            const string originalCode = @"namespace icsc
                {
                    class Program
                    {
                        static void Main(string[] args)
                        {
                            if (args.Length < 1)
                            {
                            Console.WriteLine(""No parameters"");
                            return;
                            }
                        }
                    }
                }";
            var nonModifiedCode = MainParser.OneFileCodeModification(originalCode);
            Assert.AreEqual(nonModifiedCode, originalCode);
        }
    }
}
