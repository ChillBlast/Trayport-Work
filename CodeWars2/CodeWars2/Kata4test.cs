using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars2;
using NUnit.Framework;



    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("01011110001100111", Kata4.FakeBin("45385593107843568"));
            Assert.AreEqual("101000111101101", Kata4.FakeBin("509321967506747"));
            Assert.AreEqual("011011110000101010000011011", Kata4.FakeBin("366058562030849490134388085"));
        }
    }
