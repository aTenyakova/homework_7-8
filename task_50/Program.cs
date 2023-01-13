// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void GetMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {        
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix [i,j] = new Random().Next(0, 10);
            }   
        }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine(); 
    }
}

Console.Write("Введите позицию элемента строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента столбца: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [5,5];
GetMatrix(numbers);

if (m > numbers.GetLength(0) || n > numbers.GetLength(1))
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine($"Результат: {numbers[m-1, n-1]}");
}

PrintArray(numbers);