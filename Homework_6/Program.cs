﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// Console.Write("ВВедите число");
// int amount= Convert.ToInt32(Console.ReadLine());
// if (amount <=0)
// {
//     Console.WriteLine (" Ошибка! ВВедите число!");
// }

// int count =0;
// for (int i = 0; i< amount ; i++);
// {
//   Console.WriteLine ("Введите число");  
//   int num = Convert.ToInt32(Console.ReadLine());
//   if (num >0)
//   {
//     count+=1;
//   }
// }
// Console.WriteLine ($"Количество чисел больше нуля равно (count)");  

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine ("ВВедите число k1");
double k1 =Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("ВВедите число b1");
double b1 =Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("ВВедите число k2");
double k2 =Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("ВВедите число b2");
double b2 =Convert.ToInt32(Console.ReadLine());

double x=(b2-b1)/(k1-k2);
double y=k1 * x+ b1;

Console.WriteLine ($"Две прямые пересекутся в точке с координатоми ({x},{y})");