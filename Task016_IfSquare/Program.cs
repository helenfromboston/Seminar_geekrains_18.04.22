Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA==Math.Pow(numberB, 2) | numberB==Math.Pow(numberA, 2))
// Math.Pow - возведение в степень: (переменная, степень), pow - power - "степень"
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}

//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.