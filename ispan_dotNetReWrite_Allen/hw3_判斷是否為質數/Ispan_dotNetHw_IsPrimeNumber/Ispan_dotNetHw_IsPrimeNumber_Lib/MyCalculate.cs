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
            // 判斷2的倍數是否整除，但2是質數
            if (inputNum % 2 == 0) return false;
            if (inputNum == 2) return true;
            // 判斷非2的倍數是否整除，記得有完全平方數例如9
            for (int i = 3; i <= RootInputNum; i += 2)
            {
                if (inputNum % i == 0) return false;
            }
            return true;
        }
    }
}