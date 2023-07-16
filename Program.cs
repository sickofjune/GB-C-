//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// int num = int.Parse(Console.ReadLine());
// if (num % 10 == num / 10000 && (num % 100)/10 == (num / 1000)%10){
//     Console.WriteLine("Да");
// }
// else Console.WriteLine("Нет");




// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int num_x1 = int.Parse(Console.ReadLine());
// int num_y1 = int.Parse(Console.ReadLine());
// int num_z1 = int.Parse(Console.ReadLine());
// int num_x2 = int.Parse(Console.ReadLine());
// int num_y2 = int.Parse(Console.ReadLine());
// int num_z2 = int.Parse(Console.ReadLine());
// double result = Math.Sqrt(Math.Pow(num_x2-num_x1,2) + Math.Pow(num_y2-num_y1,2) + Math.Pow(num_z2-num_z1,2));
// result = Math.Round(result, 2);
// Console.WriteLine(result);




// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Число: ");
// int num = int.Parse(Console.ReadLine());
// int result = 1;
// for (int i = 1; i <= num; i++)
// {
//     result = i * i * i;
//     Console.WriteLine(result);
// }