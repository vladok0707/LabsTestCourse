using NUnit.Framework;
using Triangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void FirstUnitTest()
        {
            Assert.IsFalse(TriangleAccept.Check(2, 2, 4));
        }
        [Test]
        public void SecondUnitTest()
        {
            Assert.IsFalse(TriangleAccept.Check(0, 2, 4));
        }
        [Test]
        public void ThirdUnitTest()
        {
            Assert.IsFalse(TriangleAccept.Check(0, 0, 1));
        }
        [Test]
        public void FourthUnitTest()
        {
            Assert.IsFalse(TriangleAccept.Check(3, 0, 3));
        }
        [Test]
        public void FifthUnitTest()
        {
            Assert.IsFalse(TriangleAccept.Check(0, 0, 0));
        }
        [Test]
        public void SixthUnitTest()
        {
            Assert.IsFalse(TriangleAccept.Check(3, 1, 0));
        }
        [Test]
        public void SeventhUnitTest()
        {
            Assert.IsFalse(TriangleAccept.Check(-3, 1, 0));
        }
        [Test]
        public void EighthUnitTest()
        {
            Assert.IsFalse(TriangleAccept.Check(3, 1, 8));
        }
        [Test]
        public void NinthUnitTest()
        {
            Assert.IsFalse(TriangleAccept.Check(3, 6, 3));
        }
        [Test]
        public void TenthUnitTest()
        {
            Assert.IsTrue(TriangleAccept.Check(5, 7, 3));
        }

    }
}