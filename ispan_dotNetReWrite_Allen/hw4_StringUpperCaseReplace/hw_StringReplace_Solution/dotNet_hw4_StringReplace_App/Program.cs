// See https://aka.ms/new-console-template for more information


using dotNet_hw4_StringReplace_Lib;

Console.WriteLine("Please Input your String: ");
// 如果null回空字串
try
{
    string inputString = Console.ReadLine() ?? string.Empty;
    StringReplaceClass StrRep = new StringReplaceClass();
    string result = StrRep.UpperCaseReplace(inputString);

    Console.WriteLine($"使用者輸入: {inputString}轉換後: {result}");

}
catch (Exception)
{
    Console.WriteLine($"不要塞奇怪的東西進來");
}

