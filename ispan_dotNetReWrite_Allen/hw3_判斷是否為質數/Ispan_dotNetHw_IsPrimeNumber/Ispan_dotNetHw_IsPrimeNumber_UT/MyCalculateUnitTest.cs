using Ispan_dotNetHw_IsPrimeNumber_Lib;

namespace Ispan_dotNetHw_IsPrimeNumber_UT
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [TestCase(1)]
        [TestCase(7)]
        public void IsPrimeNumber_代刚借计ReturnTrue(int inputNum)
        {
            MyCalculate MyCal = new MyCalculate();
            bool expected = true;
            bool actual = MyCal.IsPrimeNumber(inputNum);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2)]
        [TestCase(49)]
        [TestCase(14)]
        [TestCase(51)]
        public void IsPrimeNumber_代刚借计ReturnFalse(int inputNum)
        {
            MyCalculate MyCal = new MyCalculate();
            bool expected = false;
            bool actual = MyCal.IsPrimeNumber(inputNum);
            Assert.AreEqual(expected, actual);
        }
    }
}