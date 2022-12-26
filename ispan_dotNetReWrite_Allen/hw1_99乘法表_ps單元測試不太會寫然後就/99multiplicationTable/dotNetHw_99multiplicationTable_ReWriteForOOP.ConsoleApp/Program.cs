using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dotNetHw_99multiplicationTable_ReWriteForOOP.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MultiplicationTableUtility MultiClass = new MultiplicationTableUtility();
            Console.WriteLine(MultiClass.GetMultiplicationTable(9, 9));
            Console.ReadLine();
        }
    }
}
