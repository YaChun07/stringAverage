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
        public void Four_AverageStringTest()
        {
            Assert.AreEqual("four", StringAverage.AverageString("zero nine five two"));
            Assert.AreEqual("four", StringAverage.AverageString("five four"));
        }
        [TestMethod()]
        public void Three_AverageStringTest()
        {

            Assert.AreEqual("three", StringAverage.AverageString("four six two three"));
            Assert.AreEqual("three", StringAverage.AverageString("one two three four five"));
        }
        [TestMethod()]
        public void zero_AverageStringTest()
        {

            Assert.AreEqual("zero", StringAverage.AverageString("zero zero zero zero zero"));

        }
        [TestMethod()]
        public void na_AverageStringTest()
        {

            Assert.AreEqual("n/a", StringAverage.AverageString(""));
            Assert.AreEqual("n/a", StringAverage.AverageString("eight five six zero qjeoxp one one four qjeoxp"));
            Assert.AreEqual("n/a", StringAverage.AverageString("qjeoxp"));
        }
    }
}
