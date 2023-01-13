// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }

        Console.WriteLine();
    }
}

int[,] result = GetMatrix(5, 3, 0, 10);
PrintMatrix(result);

int GetRow(int [,] result)
{
    int row = 0;
    int minSum = 0;
    for (int j = 0; j < result.GetLength(1); j++)
    {
        minSum +=  result[0,j];
    }
    for (int i = 1; i < result.GetLength(0); i++)
    {
        int sumCell = 0;
        for (int j = 0; j < result.GetLength(1); j++)
        {
            sumCell += result[i,j];
        }
        if (minSum > sumCell)
        {
            minSum = sumCell;
            row = i + 1;
        }
    }
    return row;
}
Console.WriteLine($"Строка с наименьшей суммой элементов: {GetRow(result)}");