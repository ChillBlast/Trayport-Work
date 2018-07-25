using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars2;
using NUnit.Framework;


[TestFixture]
public class GetMiddleTest
{
    [Test]
    public void GenericTests()
    {
        Assert.AreEqual("es", Kata5.GetMiddle("test"));
        Assert.AreEqual("t", Kata5.GetMiddle("testing"));
        Assert.AreEqual("dd", Kata5.GetMiddle("middle"));
        Assert.AreEqual("A", Kata5.GetMiddle("A"));
    }
}
