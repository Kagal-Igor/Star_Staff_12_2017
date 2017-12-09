using Microsoft.VisualStudio.TestTools.UnitTesting;
using Star_staff_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_staff_1.Tests
{
    [TestClass()]
    public class SqTri90dgrTests
    {
        [TestMethod()]
        public void countSTest_345()
        {
            Assert.AreEqual(6.0, SqTri90dgr.countS(3, 4, 5));
            Assert.AreEqual(6.0, SqTri90dgr.countS(3, 4f, 5.0));
            Assert.AreEqual(30.0, SqTri90dgr.countS(13, 12, 5));
        }

        [TestMethod()]
        public void countSTest_m145()
        {
            Assert.AreEqual(null, SqTri90dgr.countS(-1, 4, 5));
        }

        [TestMethod()]
        public void countSTest_minus145()
        {
            Assert.AreEqual(null, SqTri90dgr.countS(-1, 4, 5));
        }

        [TestMethod()]
        public void countSTest_stringA45()
        {
            Assert.AreEqual(null, SqTri90dgr.countS("A", 4, 5));
        }

        [TestMethod()]
        public void countSTest_string345()
        {
            Assert.AreEqual(6.0, SqTri90dgr.countS("3", 4, 5));
        }
        [TestMethod()]
        public void countSTest_245()
        {
            Assert.AreEqual(null, SqTri90dgr.countS(2, 4, 5));
        }
    }
}