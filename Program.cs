//Дан массив размером N.
//Найти элементы с минимальной разницей  значений

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
    WriteLine($" минимальная разница между элементами {massivWork[1]}");
   
 