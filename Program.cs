// Напишите программу, которая принимает на вход трехзначное число 
// на выходе показывает вторую цифру

/*using static System.Console;
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


/*Write("Ввидите число N ");
string N = ReadLine()!;
if (N.Length > 2)
    WriteLine($"третье число {N[2].ToString()}");
else 
    WriteLine(" третьего знака нет ");*/



//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

using static System.Console ;
 Clear () ;

int ReadFromConsole(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt16(ReadLine());
}

int Summa(int numberTerms)
{
    int summa=0;
    for(int i=1; i<=numberTerms; i++)
    {
        summa+=i ;
    }
    return summa;
}

string text=(" Введите число элементов ряда ");
int number = ReadFromConsole(text);
int summ=Summa(number);
WriteLine($" Сумма {number} элементов -> {summ} ");

