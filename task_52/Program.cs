// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] result = GetMatrix(rows, columns, 0, 10);
PrintMatrix(result);
Console.WriteLine("Среднее арифметическое элементов каждого столбца: ");

void GetAverage(int[,] result)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        int average = 0;
        for (int i = 0; i < result.GetLength(0); i++)
        {
            average = (average + result[i, j]);
        }
        average = average / rows;
        Console.Write(average + "\t");
    }
}
GetAverage(result);