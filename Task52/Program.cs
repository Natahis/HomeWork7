// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3


int[,] GreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(j < matrix.GetLength(1) - 1 ? $"{matrix[i, j],3}," : $"{matrix[i, j],3}");
        }
        Console.WriteLine("]");
    }
}

int[,] arr2D = GreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(arr2D);
Console.WriteLine();
Console.Write($"Среднее арифметическое каждого столбца: ");

for (int j = 0; j < arr2D.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        sum = sum + arr2D[i, j];

    }
    double result = sum / arr2D.GetLength(0);
    Console.Write($"{Math.Round(result, 2, MidpointRounding.ToZero)}; ");

}








