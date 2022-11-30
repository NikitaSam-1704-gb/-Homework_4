//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5
 
using static System.Console ;
Clear ();

int InputConsoleNumber(string message)
{
    WriteLine(message);
    int n=Convert.ToInt32(ReadLine());
    return n;
}


int CountDigir(int number)
{
    int count=0;
    while(number>0)
    {
        number=number/10;
        count++;
    }
    return count; 
}


int numberWork=InputConsoleNumber("Введите число -> ");
int countWork=CountDigir(numberWork);

   WriteLine($" Количество цифр в числе -> {countWork} "); 