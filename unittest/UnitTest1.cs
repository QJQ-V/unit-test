using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unittest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() => Assert.IsTrue(1 == 2, "错误信息1");

        [TestMethod]
        public void TestMethod2() => Assert.IsFalse(1 == 2, "错误信息2");
    }
}
