//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

using static System.Console;
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
PrintArray(arrayWork);
