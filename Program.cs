//Дан массив размером N.
//Найти номер первого локального минимуму

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
else WriteLine($" Номер позиции локального минимума {localMin}");


