/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Написать программу, которая принимает на вход два числа и проверяет, является ли одно из них квадратом другого.
5, 25 -> Да
-4, 16 -> Да
25, 5 -> Да
8, 9 -> Нет
*/

Console.WriteLine("Программа проверяет, является ли одно из введённых чисел квадратом другого");
Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int squareNumberOne = numberOne * numberOne;
int squareNumberTwo = numberTwo * numberTwo;

if ((numberOne == squareNumberTwo) || (numberTwo == squareNumberOne))
    Console.WriteLine("Является");
else
    Console.WriteLine("Не является");