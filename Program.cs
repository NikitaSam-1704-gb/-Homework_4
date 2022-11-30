//Дан массив размером N.
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
 }