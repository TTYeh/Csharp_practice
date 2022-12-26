using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dotNetHw_99multiplicationTable_ReWriteForOOP
{
    public class MultiplicationTableUtility
    {
        //private int _multiplicand_end;
        //private int _multiplier_end;
        public string GetMultiplicationTable(int multiplicand_end, int multiplier_end)
        {
            // 被乘數multiplicand從2開始;
            // 乘數multiplier從1開始;          
            string result = string.Empty;
            for (int multiplicand = 2; multiplicand <= multiplicand_end; multiplicand++)
            {
                for (int multiplier = 1; multiplier <= multiplier_end; multiplier++)
                {
                    //result += $"{multiplicand} * {multiplier} = {multiplicand * multiplier}\n";
                    result += MultiCoreString(multiplicand, multiplier);
                }
                result += "< ... 這裡要空一行 ...>\n";
            }
            // winForm要 轉"\r\n" 主控台應用不用
            // result.Replace("\n", "\r\n");   
            return result;

        }
        private string MultiCoreString(int multiplicand, int multiplier)
        {
            return $"{multiplicand} * {multiplier} = {multiplicand * multiplier}\n";
        }
    }
}
