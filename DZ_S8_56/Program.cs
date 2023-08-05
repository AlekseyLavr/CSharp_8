// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int [,] InputArray (int rows, int collumns)
{
    int [,] createdArray = new int[rows, collumns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < collumns; j++)
            createdArray[i,j] = new Random().Next(0,10);
    return createdArray;
}

void PrintArray (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write (matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MinSumRow(int [,] array)
{
    int[] sumRowArray = new int[array.GetLength(0)];
    int sum;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i,j];
            }
        sumRowArray[i] = sum;
    }
    int minSumArr = sumRowArray[0];
    int numRow = 1;
    for (int k = 0; k < sumRowArray.Length; k++)
    {
        if (sumRowArray[k] < minSumArr)
        {
            minSumArr = sumRowArray[k];
            numRow = k + 1;
        }
    }
    Console.Write($"Минимальной являетяся строка {numRow}");
}

Console.Write("Введите количество строк: ");
int rows1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int collumns1 = Convert.ToInt32(Console.ReadLine());

int[,] arrayTask = InputArray(rows1, collumns1);
PrintArray(arrayTask);
MinSumRow(arrayTask);