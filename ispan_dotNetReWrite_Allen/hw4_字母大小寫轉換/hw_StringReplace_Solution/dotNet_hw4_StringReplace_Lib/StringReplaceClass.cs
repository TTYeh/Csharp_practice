using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_hw4_StringReplace_Lib
{
    public class StringReplaceClass
    {
        public string UpperCaseReplace(string inputStr)
        {
            StringBuilder output = new StringBuilder();
            bool firstEle = true;
            foreach (char c in inputStr)
            {
                if (char.IsUpper(c) && firstEle)
                {
                    output.Append(Char.ToLower(c));
                }
                else if (char.IsUpper(c))
                {
                    output.Append("_" + Char.ToLower(c));
                }
                else
                {
                    output.Append(Char.ToLower(c));
                }
                firstEle = false;
            }
            return output.ToString();
        }
    }
}
