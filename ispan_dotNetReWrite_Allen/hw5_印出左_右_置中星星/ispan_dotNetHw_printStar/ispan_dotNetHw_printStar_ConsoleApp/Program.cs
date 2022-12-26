using ispan_dotNetHw_printStar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispan_dotNetHw_printStar_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawLib Draw= new DrawLib();
            Console.WriteLine("偏左直角星星");
            //Console.WriteLine(Draw.LeftStar(5));
            Console.WriteLine(Draw.DrawLogic(5, Draw.LeftStarMethod));
            Console.WriteLine("偏右直角星星");
            //Console.WriteLine(Draw.RightStar(5));
            Console.WriteLine(Draw.DrawLogic(5, Draw.RightStarMethod));
            Console.WriteLine("偏中正三角星星");
            //Console.WriteLine(Draw.MidStar(5));
            Console.WriteLine(Draw.DrawLogic(5, Draw.MidStarMethod));
            Console.ReadLine();
        }
    }
}
