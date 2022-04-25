// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number < 100) Console.Write($"В числе {number} третьей цифры нет");
else
{
    while (number > 999)
    {
        number = number / 10;
    }
    Console.Write($"Третья цифра – {number % 10}");
}