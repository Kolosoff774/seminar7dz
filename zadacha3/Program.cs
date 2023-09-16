/* Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) 
{
    //                       0        1
    int[,] matrix = new int[rows, columns];
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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
        Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

double[] AverageElemDiagonalMatrix(int[,] matrix) 
{
    int sum = 0;
    double x = matrix.GetLength(0);
    double[] res = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++) 
    {
        for (int j = 0; j < matrix.GetLength(0); j++) 
        {
            sum += matrix[j, i];
        }
        res[i] = sum / x;
        sum = 0;
    }
    return res;
}

int[,] array2d = CreateMatrixRndInt(4, 5, 1, 9);
PrintMatrix(array2d);

double[] averElem = AverageElemDiagonalMatrix(array2d);
Console.Write("Среднее арифметическое каждого столбца: ");
for (int i = 0; i < averElem.Length; i++) 
{
    if (i < averElem.Length - 1) Console.Write($"{Math.Round(averElem[i], 1)}, ");
    else Console.Write(averElem[i]);
}