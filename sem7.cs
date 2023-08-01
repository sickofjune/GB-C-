// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// int m = int.Parse(Console.ReadLine());
// int n = int.Parse(Console.ReadLine());
// Random rand = new Random();

// double[,] arr = new double[m,n];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         arr[i,j] = rand.Next(-10, 10) + rand.NextDouble();
//     }
// }

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write(arr[i,j] + "\t");
//     }
//     Console.WriteLine();
// }


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int m = int.Parse(Console.ReadLine());
// int n = int.Parse(Console.ReadLine());
// Random rand = new Random();

// double[,] arr = new double[m,n];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         arr[i,j] = rand.Next(-10, 10) + rand.NextDouble();
//     }
// }

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write(arr[i,j] + "\t");
//     }
//     Console.WriteLine();
// }

// int a = Convert.ToInt32(Console.ReadLine());
//  int b = Convert.ToInt32(Console.ReadLine());
//  if (a>m && b>n)
//  Console.WriteLine("Числа нет");
//  else
//  {
//  object c = arr.GetValue(a,b);
//  Console.WriteLine(c);
//  }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int m = int.Parse(Console.ReadLine());
// int n = int.Parse(Console.ReadLine());
// Random rand = new Random();
// double sum = 0;

// int[,] arr = new int[m,n];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         arr[i,j] = rand.Next(-10, 10);
//     }
// }

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write(arr[i,j] + "\t");
//     }
//     Console.WriteLine();
// }

// for (int j = 0; j < m; j++)
// {
//     for (int i = 0; i < n; i++)
//     {
//         sum = sum + arr[i,j];
//     }
//     sum /= n;
//     Console.WriteLine($"стобец {j+1} = " +sum);
//     sum = 0;
// }