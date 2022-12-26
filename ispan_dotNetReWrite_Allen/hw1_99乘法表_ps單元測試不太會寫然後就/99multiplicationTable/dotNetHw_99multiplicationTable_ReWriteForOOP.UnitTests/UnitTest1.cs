namespace dotNetHw_99multiplicationTable_ReWriteForOOP.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(2,3)]
        public void MultiCoreString_�O���w�r��(int firstNumber, int secondNumber)
        {
            MultiplicationTableUtility MultiClass = new MultiplicationTableUtility();
            string expected = $"2 * 1 = 2\n2 * 2 = 4\n2 * 3 = 6\n< ... �o�̭n�Ť@�� ...>\n";
            string actual = MultiClass.GetMultiplicationTable(firstNumber, secondNumber);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}