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


/*//Дан массив размером N.
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

 WriteLine($" Значение максимального локального минимума {localMinWork}");*/

/*//Дан массив размером N.
//Найти максимальную сумму соседних элементов и вывести в порядке возрастания

using static System.Console ;
Clear ();

int[] FillArrayRamdom(int size)
{
    int[] array = new int[size];
    for(int i=0; i<array.Length; i++)
        array[i]=new Random().Next(0,11);
    return array;
}

void PrintArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
        Write(array[i] + " ");
    WriteLine();
}

int[] MaximumAmountAdjacentPair(int [] array)
{
    int[] massiv = new int[5];
    massiv[0]=-1;
    if(array.Length<=1)
        return massiv;
    int summTemp;
    int temp;
    massiv[3]=array[0];
    massiv[4]=array[1];
    for(int i=1; i<array.Length; i++)
    {

        massiv[1]=array[i-1];
        massiv[2]=array[i];
        summTemp= massiv[1]+massiv[2];
        if(summTemp>massiv[0])
        {
            massiv[0]=summTemp;
            if(massiv[1]>massiv[2])
            {
                temp=massiv[1];
                massiv[3]=massiv[2];
                massiv[4]=temp;
            }
        }   
    } 
    return massiv; 
}


Write("Введите размерность массива N -> ");
int n=Convert.ToInt16(ReadLine());

int[] arrayWork=FillArrayRamdom(n);
PrintArray(arrayWork);
int[] massivWork=MaximumAmountAdjacentPair(arrayWork);

if(massivWork[0]==-1)
   WriteLine(" Необходимое количество элементов массива два и более "); 
else 
 {
    WriteLine($" Значение максимальной суммы соседних элементов {massivWork[0]}");
    WriteLine($" Значение элементов {massivWork[3]}  {massivWork[4]}");
 }*/

 //Дан массив размером N.
//Найти элементы с минимальной разницей  значений

/*using static System.Console ;
Clear ();

int[] FillArrayRamdom(int size)
{
    int[] array = new int[size];
    for(int i=0; i<array.Length; i++)
        array[i]=new Random().Next(0,11);
    return array;
}

void PrintArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
        Write(array[i] + " ");
    WriteLine();
}

int[] ElementsMinimalDifference(int [] array)
{
    int[] massiv = new int[2];
    massiv[0]=-1;
    if(array.Length<=1)
        return massiv;
    else massiv[0]=0;
    int summMin;
    massiv[1]=Math.Abs(array[0]-array[1]);
    for(int i=2; i<array.Length; i++)
    {
        summMin= Math.Abs(array[i-1]-array[i]);
        if(summMin<massiv[1])
            massiv[1]=summMin;
    } 
    return massiv; 
}


Write("Введите размерность массива N -> ");
int n=Convert.ToInt16(ReadLine());

int[] arrayWork=FillArrayRamdom(n);
PrintArray(arrayWork);
int[] massivWork=ElementsMinimalDifference(arrayWork);
//PrintArray(massivWork);

if(massivWork[0]==-1)
   WriteLine(" Необходимое количество элементов массива два и более "); 
else 
    WriteLine($" минимальная разница между элементами {massivWork[1]}");*/
   
 
/*//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
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

   WriteLine($" Количество цифр в числе -> {countWork} "); */

/*//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
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

WriteLine($" Факториал {numberWork} равен {summWork} ");*/

//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

/*using static System.Console;
Clear();

int [] FillArrayZerosOnes(int size)
{
    int[] array =new int[size];
    for(int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(0,2);
    }
    WriteLine();
    return array;
}

void PrintArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        Write(array[i]+ " ");
    }
    WriteLine();
}

WriteLine( "Число элементов массива задано по умолчанию 8 ");
int[] arrayWork=FillArrayZerosOnes(8);
PrintArray(arrayWork);*/
