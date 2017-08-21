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
        public void Four_HasZero_FourNum_AverageStringTest()
        {
            Assert.AreEqual("four", StringAverage.AverageString("zero nine five two"));
        }
        [TestMethod()]
        public void Four_NoZero__TwoNum_AverageStringTest()
        {
            Assert.AreEqual("four", StringAverage.AverageString("five four"));
        }
        [TestMethod()]
        public void Three_HasZero_FourNum_AverageStringTest()
        {

            Assert.AreEqual("three", StringAverage.AverageString("four eight zero three"));
        }
        [TestMethod()]
        public void Three_NoZero_FiveNum_AverageStringTest()
        {
            Assert.AreEqual("three", StringAverage.AverageString("one two three four five"));
        }
        [TestMethod()]
        public void zero_AllZero_AverageStringTest()
        {

            Assert.AreEqual("zero", StringAverage.AverageString("zero zero zero zero zero"));

        }
        [TestMethod()]
        public void na_Null_AverageStringTest()
        {

            Assert.AreEqual("n/a", StringAverage.AverageString(""));
        }
        [TestMethod()]
        public void na_WrongInput_AverageStringTest()
        {

            Assert.AreEqual("n/a", StringAverage.AverageString("qjeoxp"));
        }
        [TestMethod()]
        public void na_WrongInput_WithRightInput_AverageStringTest()
        {
            Assert.AreEqual("n/a", StringAverage.AverageString("eight five six zero qjeoxp one one four qjeoxp"));
        }
    }
}
