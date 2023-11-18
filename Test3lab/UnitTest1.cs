using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _3lab;
using System.Security.Cryptography;

namespace Test3lab
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Shafa shafa = new Shafa(2.0, "Shafa1");
            
            double cost = shafa.CCost();

            Assert.AreEqual(150.0, cost);

        }


    }


    [TestClass]
    public class UnitTest2 {

        [TestMethod]
        public void TestMethod1() {
            Divan divan = new Divan(3.0, "Divan1");

            double cost = divan.CCost();

            Assert.AreEqual(5003, cost);
        }
    }
}
