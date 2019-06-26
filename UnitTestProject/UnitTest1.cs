using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleProject;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Sum()
        {
            int a = 4;
            int b = 5;
            int expected = 9;

            int actual = Program.Sum(a, b);

            Assert.AreEqual(expected, actual);

        }
    }
}
