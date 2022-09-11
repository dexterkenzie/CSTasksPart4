using System;

// Задача 29: 
// Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите числа через пробел: ");
string numbers = Console.ReadLine();
string[] numbersList = numbers.Split(' ');

Console.Write("Ваш массив: ");

foreach (var item in numbersList) {
    Console.Write($"'{item}' ");
}

