// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

Console.WriteLine("Введите позицию элемента в двухмернои массиве: ");
Console.Write("Номер строки = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Номер столбца = ");
int n = Convert.ToInt32(Console.ReadLine());

void FoundNumbers(int[,] matrix)
{
    if (n <= matrix.GetLength(0) && m <= matrix.GetLength(0)) Console.WriteLine($"{n}, {m} -> элемент в массиве есть -> {matrix[n - 1, m - 1]}");
    else Console.WriteLine($"{n}, {m} -> такого элемента в массиве нет.");
}




int[,] arr2D = GreateMatrixRndInt(5, 5, -9, 9);
PrintMatrix(arr2D);
FoundNumbers(arr2D);

