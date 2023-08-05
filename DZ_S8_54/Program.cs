// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

void SortRowArray(int [,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i,k] < array[i,k + 1])
                {
                    temp = array[i,k + 1];
                    array[i,k + 1] = array[i,k];
                    array[i,k] = temp;
                }
            }    
}

Console.Write("Введите количество строк: ");
int rows1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int collumns1 = Convert.ToInt32(Console.ReadLine());

int[,] arrayTask = InputArray(rows1, collumns1);
PrintArray(arrayTask);
SortRowArray(arrayTask);
PrintArray(arrayTask);