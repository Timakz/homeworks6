//Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

//Console.Write("Enter the number of array elements");
//int m = Convert.ToInt32(Console.ReadLine());
//int[] Array = new int[m];

//void mas(int m)
//{
//for (int i = 0; i < m; i++)
//{
//Console.WriteLine($"Enter {i+1} array element");
//Array[i] = Convert.ToInt32(Console.ReadLine());
//}

//}

//int kol(int[] Array)
//{
//int i=0;
//int sum = 0;
//while (i < Array.Length)
//{
//if(Array[i]>0)
//sum = sum + 1;
//i = i + 1;
//}
//return sum;
//}

//mas(m);
//Console.Write($"\n Numbers greater than zero{kol(Array)}");

//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Console.WriteLine("Enter a variable b1: ");
//double b1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter a variable k1: ");
//double k1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter a variable b2: ");
//double b2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter a variable k2: ");
//double k2 = Convert.ToDouble(Console.ReadLine());

//double x = -(b1 - b2) % (k1 - k2);
//double y = k1 * x + b1;

//Console.Write($"\n The point of intersection of two straight lines: [{x},{y}]");