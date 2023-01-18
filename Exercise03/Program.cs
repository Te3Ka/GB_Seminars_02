/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Написать программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому.
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> Не кратно, остаток 4
16, 4 -> Кратно
*/

Console.WriteLine("Задайте два числа. Программа проверит, является ли второе число кратным для первого числа.");
Console.Write("Введите первое число = ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число = ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberTwo == 0)
{
    Console.WriteLine("Ошибка! Невозможно произвести деления на ноль!");
    return;
}

int result = numberOne % numberTwo;

if (result == 0)
    Console.WriteLine("Кратно");
else
    Console.WriteLine("Не кратно. Остаток от деления = " + result);