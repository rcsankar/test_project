using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ICalculator worker = new Functions();
            int result = worker.Sum(string.Empty);

            Console.WriteLine(string.Format("Result of the Summation = {0}", result));
        }

        [TestMethod]
        public void TestMethod2()
        {
            ICalculator worker = new Functions();
            int result = worker.Sum("5");

            Console.WriteLine(string.Format("Result of the Summation = {0}", result));
        }

        [TestMethod]
        public void TestMethod3()
        {
            ICalculator worker = new Functions();
            int result = worker.Sum("5,25,35,75");

            Console.WriteLine(string.Format("Result of the Summation = {0}", result));
        }
    }
}
