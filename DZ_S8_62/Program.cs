// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получится вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < 10)
                Console.Write("0");
            Console.Write (matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(" ");
}

int [,] CreatSpiralArray (int rowAll, int collAll)
{
    int [,] array = new int [rowAll, collAll];
    int side = 1;
    int rowTemp = 0;
    int collTemp = 0;
    int numTemp = 1;
    for (int i = 1; i <= rowAll*collAll; i++)
    {
        array[rowTemp,collTemp] = numTemp;
        numTemp++;
        if (side == 1)
        {
            if (collTemp + 1 >= collAll || array[rowTemp, collTemp +1] != 0)
            {
                side = 2;
                rowTemp++;
            }
            else collTemp++;
        }
        else if (side == 2)
        {
            if (rowTemp +1 >= rowAll || array[rowTemp + 1,collTemp] != 0)
            {
                side = 3;
                collTemp--;
            }
            else rowTemp++;
        }
        else if (side == 3)
        {
            if (collTemp - 1 < 0 || array[rowTemp,collTemp - 1] != 0)
            {
                side = 4;
                rowTemp--;
            }
            else collTemp--;
        }
        else if (side == 4)
        {
            if (rowTemp - 1 < 0 || array[rowTemp - 1,collTemp] != 0)
            {
                side = 1;
                collTemp++;
            }
            else rowTemp--;
        }
    }
    return array;
}

int[,] arrayTask = CreatSpiralArray(4,4);
PrintArray(arrayTask);
