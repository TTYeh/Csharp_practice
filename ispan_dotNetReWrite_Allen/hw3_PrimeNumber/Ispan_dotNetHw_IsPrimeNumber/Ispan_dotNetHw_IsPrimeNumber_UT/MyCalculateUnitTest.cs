using Ispan_dotNetHw_IsPrimeNumber_Lib;

namespace Ispan_dotNetHw_IsPrimeNumber_UT
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(7)]
        public void IsPrimeNumber_���ս��ReturnTrue(int inputNum)
        {
            MyCalculate MyCal = new MyCalculate();
            bool expected = true;
            bool actual = MyCal.IsPrimeNumber(inputNum);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(14)]
        [TestCase(51)]
        public void IsPrimeNumber_���ս��ReturnFalse(int inputNum)
        {
            MyCalculate MyCal = new MyCalculate();
            bool expected = false;
            bool actual = MyCal.IsPrimeNumber(inputNum);
            Assert.AreEqual(expected, actual);
        }
    }
}