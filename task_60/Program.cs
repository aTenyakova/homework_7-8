// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] GetMatrix(int m, int n, int z, int minValue, int maxValue)
{
    int[,,] matrix = new int[m, n, z];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < inputMatrix.GetLength(2); k++)
            {
                Console.Write($"{inputMatrix[i, j, k]} ({i},{j},{k})" + "\t");
            }
        }
        Console.WriteLine();
    }
}

int[,,] result = GetMatrix(3, 3, 3, 10, 100);
PrintMatrix(result);