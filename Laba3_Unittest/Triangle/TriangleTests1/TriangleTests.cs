using NUnit.Framework;
using Triangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle.Tests
{
    [TestFixture()]
    public class TriangleTests
    {
        [Test()]
        public void Triangle_2and2and4_falseReturned()
        {
            float x = 2;
            float y = 2;
            float z = 4;
            bool expected = false;

            TriangleAccept t = new TriangleAccept();
            bool actual = t.Triangle(x, y, z);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void Triangle_0and2and4_falseReturned()
        {
            float x = 0;
            float y = 2;
            float z = 4;
            bool expected = false;

            TriangleAccept t = new TriangleAccept();
            bool actual = t.Triangle(x, y, z);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void Triangle_0and0and1_falseReturned()
        {
            float x = 0;
            float y = 0;
            float z = 1;
            bool expected = false;

            TriangleAccept t = new TriangleAccept();
            bool actual = t.Triangle(x, y, z);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void Triangle_3and0and3_falseReturned()
        {
            float x = 3;
            float y = 0;
            float z = 3;
            bool expected = false;

            TriangleAccept t = new TriangleAccept();
            bool actual = t.Triangle(x, y, z);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void Triangle_0and0and0_falseReturned()
        {
            float x = 0;
            float y = 0;
            float z = 0;
            bool expected = false;

            TriangleAccept t = new TriangleAccept();
            bool actual = t.Triangle(x, y, z);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void Triangle_3and1and0_falseReturned()
        {
            float x = 3;
            float y = 1;
            float z = 0;
            bool expected = false;

            TriangleAccept t = new TriangleAccept();
            bool actual = t.Triangle(x, y, z);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void Triangle_minus3and1and8_falseReturned()
        {
            float x = -3;
            float y = 1;
            float z = 0;
            bool expected = false;

            TriangleAccept t = new TriangleAccept();
            bool actual = t.Triangle(x, y, z);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void Triangle_3and1and8_trueReturned()
        {
            float x = 3;
            float y = 1;
            float z = 8;
            bool expected = true;

            TriangleAccept t = new TriangleAccept();
            bool actual = t.Triangle(x, y, z);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void Triangle_1andminus1and8_falseReturned()
        {
            float x = 1;
            float y = -1;
            float z = 8;
            bool expected = false;

            TriangleAccept t = new TriangleAccept();
            bool actual = t.Triangle(x, y, z);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void Triangle_10and15andminus8_trueReturned()
        {
            float x = 10;
            float y = 15;
            float z = -8;
            bool expected = false;

            TriangleAccept t = new TriangleAccept();
            bool actual = t.Triangle(x, y, z);
            Assert.AreEqual(expected, actual);
        }

    }
}