using dotNet_hw4_StringReplace_Lib;

namespace dotNet_hw4_StringReplace_UT
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("AppleCat")]
        public void IsPrimeNumber_�����r�j�g_��L���t�j�g(string inputString)
        {
            StringReplaceClass MyCal = new StringReplaceClass();
            string expected = "apple_cat";
            string actual = MyCal.UpperCaseReplace(inputString);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("bananaUU")]
        public void IsPrimeNumber_�����r�D�j�g_��L���t�j�g(string inputString)
        {
            StringReplaceClass MyCal = new StringReplaceClass();
            string expected = "banana_u_u";
            string actual = MyCal.UpperCaseReplace(inputString);
            Assert.AreEqual(expected, actual);
        }
        [TestCase("ccc")]
        public void IsPrimeNumber_�����r�D�j�g_��L���t�D�j�g(string inputString)
        {
            StringReplaceClass MyCal = new StringReplaceClass();
            string expected = "ccc";
            string actual = MyCal.UpperCaseReplace(inputString);
            Assert.AreEqual(expected, actual);
        }
    }
}