namespace Ispan_dotNetHw_IsPrimeNumber_Lib
{
    public class MyCalculate
    {
        public bool IsPrimeNumber(int inputNum) 
        {
            // 非正整數,0,1直接false
            if (inputNum < 2 ) return false;
            // for迴圈判斷到 輸入數值的根號(無條件進位最小整數)次
            int RootInputNum = (int)Math.Ceiling(Math.Pow(inputNum, 0.5));
            // 判斷2的倍數是否整除
            if (inputNum % 2 == 0) return false;
            // 判斷非2的倍數是否整除
            for (int i = 3; i < RootInputNum; i += 2)
            {
                if (inputNum % i == 0) return false;
            }
            return true;
        }
    }
}