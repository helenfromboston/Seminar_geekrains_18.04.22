Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA % numberB == 0)
{
    Console.WriteLine($"Число {numberA} кратно числу {numberB}");
}
else
{
    Console.WriteLine($"Число {numberA} не кратно числу {numberB}, остаток от деления = {numberA % numberB}");
}

//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.