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

//>>>>>>> master
