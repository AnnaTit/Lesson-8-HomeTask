// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/* int[,] CreateRandomArray()
    {
        Console.Write("Input quantity rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input quantity columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input minValue: ");
        int minValue = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input maxValue: ");
        int maxValue = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[rows, columns];
        for(int i = 0; i<rows; i++)
            for(int j = 0; j<columns; j++)
                array[i,j] = new Random().Next(minValue, maxValue);
        return array;
    }
void ShowArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
        {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
        }
    Console.WriteLine();
  }
  
void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
int[,] newArray = CreateRandomArray();
ShowArray(newArray);
SortToLower(newArray);
ShowArray(newArray); */

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов
/* int[,] CreateRandomArray()
    {
        Console.Write("Input quantity rows & columns: ");
        int elements = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input minValue: ");
        int minValue = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input maxValue: ");
        int maxValue = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[elements, elements];
        for(int i = 0; i<elements; i++)
            for(int j = 0; j<elements; j++)
                array[i,j] = new Random().Next(minValue, maxValue);
        return array;
    }
void ShowArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
        {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
        }
    Console.WriteLine();
  }
int [,] array = CreateRandomArray();
    ShowArray(array);

int SumString(int[,] array, int i)
{
    int sumString = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumString += array[i,j];
    }
    return sumString;
}
int minSumString = 0;
int sumString = SumString(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumString = SumString(array, i);
    if (sumString > tempSumString)
    {
        sumString = tempSumString;
        minSumString = i;
    }
}
Console.WriteLine($"\n{minSumString+1} - string with lower sum is ({sumString})"); */

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/* int rows = ReadInt("Input number of strings: ");
int columns = ReadInt("Input number of columns: ");
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

FillArrayRandom(array);
ShowArray(array);

Console.WriteLine();

FillArrayRandom(secondArray);
ShowArray(secondArray);

Console.WriteLine();

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Not possible to multiply arrays ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}
ShowArray(resultArray);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
} */

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

Console.Write("Input size of side: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] nums = new int[size, size];
int num = 1;
int i = 0;
int j = 0;
while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}
ShowArray(nums);
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
