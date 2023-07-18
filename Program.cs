// int[] generateArray(int lenght, int minValue, int maxValue)  // Генерация массива типа int
// {
//     int [] arr = new int[lenght];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return arr;
// }

// double[] generateDoubleArray(int lenght)  // Генерация массива типа double
// {
//     double [] arr = new double[lenght];
//     Random rand = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(-100, 100) + rand.NextDouble();
//     }
//     return arr;
// }

// double raznicaMaxMin(double[] arr) // Разница между максимальным и минимальным элементов массива double
// {
//     double temp1 = arr[0];
//     double temp2 = arr[0];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] > temp1) temp1 = arr[i];
//     }
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] < temp2) temp2 = arr[i];
//     }

//     return temp1 - temp2;
// }

// int sumEvenNumbers(int[] arr) // Сумма четных чисел массива
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0) count += 1;
//     }
//     return count;
// }

// int sumOddIndex(int[] arr) // Сумма элементов неченых индексов
// {
//     int count = 0;
//     for (int i = 1; i < arr.Length; i=i+2)
//     {
//         count = count + arr[i];
//     }
//     return count;
// }

// Console.WriteLine("ЗАДАНИЕ 1");   // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// int[] arr1 = generateArray(6, 100, 998);
// for (int i = 0; i < arr1.Length; i++)
// {
//     Console.Write(arr1[i] + ", ");
// }
// int result = sumEvenNumbers(arr1);
// Console.WriteLine();
// Console.WriteLine(result);


// Console.WriteLine("ЗАДАНИЕ 2");   // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// int[] arr2 = generateArray(8, -100, 99);
// for (int i = 0; i < arr2.Length; i++)
// {
//     Console.Write(arr2[i] + ", ");
// }
// Console.WriteLine();
// int sum = sumOddIndex(arr2);
// Console.WriteLine(sum);


// Console.WriteLine("ЗАДАНИЕ 3"); // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// double[] arr3 = generateDoubleArray(5);
// for (int i = 0; i <arr3.Length; i++)
// {
//     Console.Write(arr3[i] + ", ");
// }
// Console.WriteLine();
// Console.WriteLine(raznicaMaxMin(arr3));