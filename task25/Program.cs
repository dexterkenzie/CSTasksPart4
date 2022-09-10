﻿using System;

// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine($"Вы ввели числа {numberA} и {numberB}"); // проверка ввода данных
Console.WriteLine($"{numberA} ^{numberB} = {Math.Pow(numberA, numberB)}"); // вывод ответа 
