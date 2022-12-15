using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_detNet
{
    internal class MultiplicationTableYtility
    {
        // 如何定義class的方法?
        
        public string mulCalculate(int multiplicand, int multiplier)
        {
            string a = $"{multiplicand} * {multiplier} = {multiplicand * multiplier}\n";
            return a;
        }        
        
        
    }
}
