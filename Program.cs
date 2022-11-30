// Напишите программу, которая принимает на вход трехзначное число 
// на выходе показывает вторую цифру

using static System.Console;
Clear() ;

/*int ConsoleInput(string text )
{
    WriteLine(text) ;
    return Convert.ToInt32(ReadLine());
}

int NumberSecondDigit (int num)
{
     num=num%100;
     num=num/10;
     return num;
}

int number = ConsoleInput(" Введите трехзначное число ");
int result=NumberSecondDigit(number);
WriteLine($" число во втором разряде -> {result}");*/


Write("Ввидите число N ");
string N = ReadLine()!;
if (N.Length > 2)
    WriteLine($"третье число {N[2].ToString()}");
else 
    WriteLine(" третьего знака нет ");
