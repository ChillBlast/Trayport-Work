using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars2;

namespace CodeWars2
{
    using NUnit.Framework;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(23, Kata6.Solution(10));
        }
    }
}
