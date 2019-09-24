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
        public void Triangle_3and2and4_falseReturned()
        {
            float y = 3;
            float x = 2;
            float z = 4;
            bool expected = false;

            TriangleAccept t = new TriangleAccept();
            bool actual =  t.Triangle(y, x, z);
            Assert.AreEqual(expected, actual);
        }
    }
}