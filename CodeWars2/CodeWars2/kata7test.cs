using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace CodeWars2
{
    [TestFixture]
    public class KataTest7
    {
        [Test]
        public void KataTests()
        {
            Assert.AreEqual(0, Kata7.DuplicateCount(""));
            Assert.AreEqual(0, Kata7.DuplicateCount("abcde"));
            Assert.AreEqual(2, Kata7.DuplicateCount("aabbcde"));
            Assert.AreEqual(2, Kata7.DuplicateCount("aabBcde"), "should ignore case");
            Assert.AreEqual(1, Kata7.DuplicateCount("Indivisibility"));
            Assert.AreEqual(2, Kata7.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }
    }
}
