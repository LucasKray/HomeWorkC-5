// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[] M = new int[5];

for (int i = 0; i < M.Length; i++)
{
    M[i] = Convert.ToInt32(Console.ReadLine());
}
int A = 0;
foreach(var B in M)
{
    if(B > 0)
    A ++;
}

Console.WriteLine(A);
*/

//Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значение");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение");
int k2 = Convert.ToInt32(Console.ReadLine());

int x, y;

while( k1 * x + b1 ==  k2 * x + b2)
