// задача 60. Сформируйте трёхмерный массив из неповторяющихся двухзначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 х 2 х 2:
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] FillArray (int row, int coll, int depth)
{
    int [,,] filledArray = new int[row,coll,depth];
    int tempSize = row*coll*depth;
    if (tempSize <= 90)
    {
        int [] tempArray = UniqueVal(tempSize);
        int iTemp = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < coll; j++)
            {
                for (int k = 0; k < depth; k++)
                {
                    if (iTemp >= 0 && iTemp < tempSize)
                    {
                        filledArray[i,j,k] = tempArray[iTemp];
                        iTemp++;
                    }
                }    
            }        
        }
    }    
    return filledArray;
}

void Print3DArray (int [,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write ($"{matrix[i,j,k]} ({i},{j},{k}) ");
            }
        Console.WriteLine();
        }
    }
    Console.WriteLine(" ");
}

int [] UniqueVal (int size)
{
    int[] uniqueArray = new int[size];
    for (int i = 0; i < size; i++)
        {
            uniqueArray[i] = new Random().Next(10, 100);
            if (i != 0)
            {
                for (int r = 0; r < i; r++)
                {
                    while (uniqueArray[r] == uniqueArray[i])
                    {
                        uniqueArray[r] = new Random().Next(10, 100);
                    }
                }
            }
        }
    return uniqueArray;
}

Console.Clear();
Console.Write("Введите количество строк: ");
int rows1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int cols1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество глубину: ");
int depth1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,,] arrayTask = FillArray(rows1, cols1, depth1);
Print3DArray(arrayTask);
