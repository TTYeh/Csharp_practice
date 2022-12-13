using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW_MyHomework
{
    internal partial class Utility
    {
        public class hw_E1_Utility {
            public static int answer;
            public static int userGuess { get; set; }
            public static int boundUpperLimit { get; set; }
            public static int boundLowerLimit { get; set; }
            public static string dispString { get; set; }
            public static int guessCount;
            // 要問是否用這些變數傳遞適當
        }

        //public struct hw_E1_Utility2 {
        //    public int answer { get; set; }
        //    public int userGuess { get; set; }
        //    public int boundUpperLimit { get; set; }
        //    public int boundLowerLimit { get; set; }

        //    public hw_E1_Utility(int inputAns, int inputUserGuess, int inputBoundU, int inputBoundL)
        //    {
        //        answer = inputAns;
        //        userGuess = inputUserGuess;
        //        boundUpperLimit = inputBoundU;
        //        boundLowerLimit = inputBoundL;
        //    }
        //}

    }
}
