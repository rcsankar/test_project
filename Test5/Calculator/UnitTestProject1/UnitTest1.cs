using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTestProject1
{
      [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void TestMethod1()
            {
                ICalculator worker = new Functions();
                int result = worker.Sum(string.Empty, new[] { ";", "\\\\" });

                Console.WriteLine(string.Format("Result of the Summation = {0}", result));
            }

            [TestMethod]
            public void TestMethod2()
            {
                ICalculator worker = new Functions();
                int result = worker.Sum("5", new[] { ";", "\\\\" });

                Console.WriteLine(string.Format("Result of the Summation = {0}", result));
            }

            [TestMethod]
            public void TestMethod3()
            {
                ICalculator worker = new Functions();
                int result = worker.Sum("5;\\25;-19", new[] { ";", "\\\\" });

                Console.WriteLine(string.Format("Result of the Summation = {0}", result));
            }
        }
}
