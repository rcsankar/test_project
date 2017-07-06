using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTest3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ICalculator worker = new Functions();
            int result = worker.Sum(string.Empty, new[] { ",", "\\n" });

            Console.WriteLine(string.Format("Result of the Summation = {0}", result));
        }

        [TestMethod]
        public void TestMethod2()
        {
            ICalculator worker = new Functions();
            int result = worker.Sum("5", new[] { ",", "\\n" });

            Console.WriteLine(string.Format("Result of the Summation = {0}", result));
        }

        [TestMethod]
        public void TestMethod3()
        {
            ICalculator worker = new Functions();
            int result = worker.Sum("5,\n25,3", new[] { ",", "\\n" });

            Console.WriteLine(string.Format("Result of the Summation = {0}", result));
        }
    }
}
