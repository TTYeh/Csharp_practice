using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_Csharp_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write輸出後不換行 */
            Console.Write("請輸入姓名:");
            string myName = Console.ReadLine();
            Console.WriteLine("Hello" + myName);
            Console.ReadKey();
        }
    }
}
