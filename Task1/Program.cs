﻿// Задание 1

// Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

void NaturNum (int m, int n)
{
    if (m>n)
    return;
    
   { 
    Console.Write($"{m}, ");
   }
    NaturNum(m+1,n);
   
}
 NaturNum(m,n);


