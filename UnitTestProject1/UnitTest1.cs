using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string ex = "Hello Wrld!";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Jenkins_test.Program.Main();
                //Tester a = new Tester();
                //a.a = 1;
                //a.b = 2;
                var result = sw.ToString().Trim();
                Assert.AreEqual(ex, result);
            }
        }
    }
}
