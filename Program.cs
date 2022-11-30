//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 5 -> 120

using static System.Console ;
Clear ();
   
int InputConsoleNumber(string message)
{
    Write(message);
    int n=Convert.ToInt32(ReadLine());
    return n;
}

double Factorial(int number)
{
    double summ=1;
    for(int i=1; i<=number; i++)
    {
        summ=summ*i;
    }
    return summ;
}

int numberWork=InputConsoleNumber("Введите натурально число N -> ");
double summWork=Factorial(numberWork);

WriteLine($" Факториал {numberWork} равен {summWork} ");
//>>>>>>> master
