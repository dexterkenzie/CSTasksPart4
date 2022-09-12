using System;

// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Вы ввели число: {number}"); // проверка ввода данных

int result = 0;
while (number > 0)
{
    int dig = number % 10;
    result = result + dig;
    number = number / 10;
}

Console.WriteLine($"Сумма цифр равна: {result}");
