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
