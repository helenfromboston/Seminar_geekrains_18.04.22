﻿Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number % 7 == 0 | number % 23 == 0)
// & - "И", одновременное выполнение условий, && - проверяет первое; | - "ИЛИ" проверяет оба, || - проверяет первое
{
    Console.Write($"Число {number} кратно одновременно 7 и 23");
}
else
{
    Console.Write($"Число {number} не кратно одновременно 7 и 23");
}

//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23