Console.Clear();
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// void initMatrix (double[,] matrix)
// {

//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i,j] = new Random().Next(-100,101) + new Random().NextDouble() ;
//     }
//   }
// }

// void printMatrix (double[,] matrix)
// {

//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//       Console.Write($" {Math.Round(matrix[i,j], 2)}");
//     }
//     Console.WriteLine();
//   }  
// }

// Console.Write("Введите число строк матрицы:  ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов матрицы:  ");
// int m = Convert.ToInt32(Console.ReadLine());
// double[,] matrix = new double[n,m];
// initMatrix(matrix);
// printMatrix(matrix);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// Пример
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Ввод:
// 2 строка
// 1 столбец
// Вывод:
// 4

// void initMatrix(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 11);
//         }
//     }
// }

// void printMatrix(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($" {matrix[i, j]}");
//         }
//         Console.WriteLine();
//     }
// }

// void findeElement(int row, int column, int[,] matrix)
// {
//     if (row > matrix.GetLength(0) - 1 
//         || column > matrix.GetLength(1) - 1
//         || row < 0 
//         || column < 0)
//         Console.WriteLine($"Элемента под индексом {row}," + $"{column} в матрице нет.");
//     else
//         Console.WriteLine($"Элемента под индексом {row}," + $"{column}: " + matrix[row, column]);
// }


// Console.Write("Введите число строк матрицы:  ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов матрицы:  ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[n, m];
// initMatrix(matrix);
// Console.WriteLine("Исходная матрица");
// printMatrix(matrix);
// Console.Write("Введите строку:  ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите столбец:  ");
// int column = Convert.ToInt32(Console.ReadLine());
// findeElement(row, column, matrix);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void initMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
        }
    }
}

void printMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]}");
        }
        Console.WriteLine();
    }
}

double[] average(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            average[j] += matrix[i, j];
            if (i == matrix.GetLength(1) - 1)
                average[j] /= average.Length;
        }
    }
    return average;
}

Console.Write("Введите число строк матрицы:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов матрицы:  ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
initMatrix(matrix);
Console.WriteLine("Исходная матрица");
printMatrix(matrix);
Console.WriteLine("Сдвинутый массив: [ " + string.Join(", ", average(matrix)) + " ]");