﻿/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет
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


void PrintResult(int numR, int numC, int[,] matrix) 
{
    Console.Write($"{numR}, {numC} -> ");
    if (SearchElementInMatrix(numR, numC, matrix) != 0) 
    {
        Console.WriteLine(SearchElementInMatrix(numR, numC, matrix));
    } 
    else 
    {
            Console.WriteLine("Такого элемента в массиве нет!");
    }
}

int SearchElementInMatrix(int numR, int numC, int [,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (numR == i && numC == j) return matrix[i, j];
        }
    }
    return 0;
}

Console.Write("Введи индекс строки: ");
int numberRows = int.Parse(Console.ReadLine());
Console.Write("Введи индекс столбца: ");
int numberColumns = int.Parse(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(5, 10, -100, 100);

if (numberRows < 0 || numberColumns < 0) Console.WriteLine("Вы ввели отрицательный индекс!");
else {
PrintMatrix(array2d);
PrintResult(numberRows, numberColumns, array2d);
}