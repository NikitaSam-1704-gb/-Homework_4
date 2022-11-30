 //Дан массив размером N.
//Найти количество участков на которых функция монотонно возрастает

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

int CountMonotonousInterval(int [] array)
{
    int count = 0;
    if(array.Length<=1)
        return count;

    for(int i=1; i<array.Length-1; i++)
    {
        int left=array[i-1];
        int middile=array[i];
        int right=array[i+1];

        if(left<=middile && middile<=right )
            count++;   
    } 
    return count; 
}


Write("Введите размерность массива N -> ");
int n=Convert.ToInt16(ReadLine());

int[] arrayWork=FillArrayRamdom(n);
PritArray(arrayWork);
int countInterval=CountMonotonousInterval(arrayWork);

if(countInterval==0)
   WriteLine(" интервалов монотонного возрастания нет "); 
 WriteLine($" Количество интервалов монотонного возрастания {countInterval}");
