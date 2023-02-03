
void printmas(int[,] arr)
{
int rows = arr.GetUpperBound(0) + 1;    // количество строк
int columns = arr.Length / rows;        // количество столбцов
 
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{arr[i, j]} \t");
    }
    Console.WriteLine();
}
}
void fillmas(int[,] arr)
{
int rows = arr.GetUpperBound(0) + 1;    // количество строк
int columns = arr.Length / rows;        // количество столбцов
 
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        arr[i, j] = new Random().Next(0,2);
    }
   }
}
void copymas(int[,] arr,int[,] arr1)
{
int rows = arr.GetUpperBound(0) + 1;    // количество строк
int columns = arr.Length / rows;        // количество столбцов
 
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        arr1[i, j] = arr[i, j];
    }
   }
}

int rows = new Random().Next(5,10);    // количество строк
int columns = new Random().Next(5,10); 
int[,] numbers = new int [rows,columns];
int[,] numbers2 = new int [rows,columns];
/*
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        numbers[i, j] = new Random().Next(0,2);
    }
}
*/
fillmas(numbers);
/*
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        numbers2[i, j] = numbers[i, j];
    }
}
*/
copymas(numbers,numbers2);
/*
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{numbers2[i, j]} \t");
    }
    Console.WriteLine();
}
*/
printmas(numbers2);