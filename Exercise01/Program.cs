/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Написать программу, которая выводит случайно число из отрезка [10, 99] и показывает наибольшую цифру этого числа
78 -> 8
12 -> 2
85 -> 8
*/

Console.WriteLine("Программа генерирует число от 10 до 99, после чего выводит наибольшее из чисел.");
int randomNumber = new Random().Next(10, 100);
Console.WriteLine("Сгенерированное число = " + randomNumber);

int numberTens = randomNumber / 10;
int numberUnits = randomNumber % 10;

if (numberTens > numberUnits)
    Console.WriteLine("Наибольшая цифра в числе: " + numberTens);
else
    Console.WriteLine("Наибольшая цифра в числе: " + numberUnits);