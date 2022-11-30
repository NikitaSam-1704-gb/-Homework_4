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

/*using static System.Console ;
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
WriteLine($" Сумма {number} элементов -> {summ} ");*/


//Дан массив размером N.
//Найти номер первого локального минимуму

/*using static System.Console ;
Clear ();

int[] FillArrayRamdom(int size)
{
    int[] array = new int[size];
    for(int i=0; i<array.Length; i++)
        array[i]=new Random().Next(1,11);
    return array;
}

void PritArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
        Write(array[i] + " ");
    WriteLine();
}

int ChekLocalMin(int [] array)
{
    if(array.Length<=1)
        return -1;

    for(int i=1; i<array.Length; i++)
    {
        int left=array[i-1];
        int middile=array[i];
        int right=array[i+1];
        if(left>middile && right>middile)
            return i;
    } 
    return -1;  
}


Write("Введите размерность массива N -> ");
int n=Convert.ToInt16(ReadLine());
int[] arrayWork=FillArrayRamdom(n);
PritArray(arrayWork);
int localMin=ChekLocalMin(arrayWork);
if(localMin==-1)
    WriteLine(" Локального минимума нет "); 
else WriteLine($" Номер позиции локального минимума {localMin}");*/


//Дан массив размером N.
//Найти максимальный из его локальных минимумов

using static System.Console ;
Clear ();

int[] FillArrayRamdom(int size)
{
    int[] array = new int[size];
    for(int i=0; i<array.Length; i++)
        array[i]=new Random().Next(1,11);
    return array;
}

void PritArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
        Write(array[i] + " ");
    WriteLine();
}

int ChekMaxLocalMin(int [] array)
{
    int localMin = -1;
    if(array.Length<=1)
        return localMin;

    for(int i=1; i<array.Length-1; i++)
    {
        int left=array[i-1];
        int middile=array[i];
        int right=array[i+1];

        if(left>middile && right>middile)
        {
            if(localMin < array[i])
               localMin=array[i];    
        }
    } 
    return localMin; 
}


Write("Введите размерность массива N -> ");
int n=Convert.ToInt16(ReadLine());

int[] arrayWork=FillArrayRamdom(n);
PritArray(arrayWork);
int localMinWork=ChekMaxLocalMin(arrayWork);

if(localMinWork==-1)
   WriteLine(" Локального минимума нет "); 

 WriteLine($" Значение максимального локального минимума {localMinWork}");
