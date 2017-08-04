using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringAverage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace StringAverage.Tests
{
    [TestClass()]
    public class StringAvg
    {
        [TestMethod()]
        public void AverageStringTest()
        {
            
            Assert.AreEqual("four", StringAverage.AverageString("zero nine five two"));
            Assert.AreEqual("three", StringAverage.AverageString("four six two three"));
            Assert.AreEqual("three", StringAverage.AverageString("one two three four five"));
            Assert.AreEqual("four", StringAverage.AverageString("five four"));
            Assert.AreEqual("zero", StringAverage.AverageString("zero zero zero zero zero"));
            Assert.AreEqual("two", StringAverage.AverageString("one one eight one"));
            Assert.AreEqual("n/a", StringAverage.AverageString(""));
            Assert.AreEqual("n/a", StringAverage.AverageString("eight five six zero qjeoxp one one four qjeoxp"));
            
        }

    }
}
