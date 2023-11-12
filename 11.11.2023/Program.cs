#region 1 ci task
using System.Text;
using tapsiriq_11._11._2023.Hidanin_Modelsleri;

Console.WriteLine("Ters cevirmek ucun string daxil edin...");
string givenString = Console.ReadLine();
StringBuilder reversedString = new();

for (int i = givenString.Length - 1; i >= 0; i--)
{
    reversedString.Append(givenString[i]);
    
}
Console.WriteLine(reversedString);

//Console.WriteLine(ChangeWord("Salam.Necesen?"));
//string ChangeWord(string word) //1-ci variant reversded string String buildersiz
//{
//    string result = string.Empty;
//    for (int i = word.Length - 1; i >= 0; i--)
//    {
//        result += word[i];

//    }
//    return result;
//}
#endregion
#region 2 ci task
Account account = new Account();
Console.WriteLine("sisteme daxil olmaq ucun username daxil et");
string Enterusername = Console.ReadLine();
Console.WriteLine("sisteme daxil olmaq ucun kodu daxil et");
string Enterpassword = Console.ReadLine();
account.Login(Enterusername, Enterpassword);
#endregion
#region 3 cu task
Factorial factorial = new Factorial();
Console.WriteLine("Istediyin ededi daxil ede bilersen");
int num = int.Parse(Console.ReadLine());
factorial.FactorialHesablanmasi(num);
#endregion
#region 4 cu task
Calculator_Class calculator_Class = new Calculator_Class();
Console.WriteLine("Birinci rəqəmi daxil edin: ");
double num1 = Convert.ToDouble(Console.ReadLine()); //doublacevirmekucun
Console.WriteLine("İkinci rəqəmi daxil edin: ");
double num2 = Convert.ToDouble(Console.ReadLine());//doublacevirmekucun
Calculator_Class calculation = new();
calculation.Calculate(5, 4);
#endregion
