// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] matrixOne = GetMatrix(3, 4, 0, 10);
Console.WriteLine("Первая матрица: ");
PrintMatrix(matrixOne);
int[,] matrixTwo = GetMatrix(3, 4, 0, 10);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(matrixTwo);

int [,] GetResultMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] resultMatrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int result = 0;
            for (i = 0; i < resultMatrix.GetLength(0); i++)
            {
                result = matrixOne[i, j] * matrixTwo[i, j];
                resultMatrix[i, j] = result;
            }
        }
    }
    return resultMatrix;
}
    Console.WriteLine("Произведение элементов двух матриц: ");
    PrintMatrix(GetResultMatrix(matrixOne, matrixTwo));