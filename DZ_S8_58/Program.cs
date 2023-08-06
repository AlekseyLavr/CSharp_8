// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3 
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMulti(int [,] matrix1, int[,] matrix2)
{
    int[,] finalMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
        for (int j = 0; j < matrix2.GetLength(1); j++)
            for (int k = 0; k < matrix2.GetLength(0); k++)
                finalMatrix[i,j] += matrix1[i,k] * matrix2[k,j];
    return finalMatrix;
}

Console.Clear();
Console.Write("Введите количество строк первой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов первой матрицы: ");
int cols1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк второй матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов второй матрицы: ");
int cols2 = Convert.ToInt32(Console.ReadLine());

if (cols1 != rows2)
    Console.WriteLine("ERROR");

int[,] arrayTask1 = InputArray(rows1, cols1);
PrintArray(arrayTask1);
int[,] arrayTask2 = InputArray(rows2, cols2);
PrintArray(arrayTask2);

int [,] resultMultiMatrix = MatrixMulti(arrayTask1, arrayTask2);
PrintArray(resultMultiMatrix);