// See https://aka.ms/new-console-template for more information
using Ispan_dotNetHw_IsPrimeNumber_Lib;

Console.WriteLine("Please Input your Number: ");
// 如果null回空字串
try
{
    string inputString = Console.ReadLine() ?? string.Empty;
    int.TryParse(inputString, out int userInput);
    string tmp = userInput == 0 ? throw new Exception($"資料格式不是大於零正整數。母湯喔") : "";
    MyCalculate MyCal = new MyCalculate();
    if (MyCal.IsPrimeNumber(userInput))
    {
        Console.WriteLine($"使用者輸入: {userInput}是質數");
    }
    else
    {
        Console.WriteLine($"使用者輸入: {userInput}不是質數");
    }
}
catch (Exception)
{
    Console.WriteLine($"資料格式不是大於零正整數。母湯喔");
}

