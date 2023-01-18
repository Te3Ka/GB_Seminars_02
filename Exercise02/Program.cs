/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Написать программу, которая генерирует случайное
трёхзначное число
и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

Console.WriteLine("Программа генерирует случайное трёхзначное целое положительное число, после чего удаляет из него вторую цифру и выводит полученный результат на экран.");
int randomNumber = new Random().Next(100, 1000);

int firstDigit = randomNumber / 100 * 10;
int secondDigit = randomNumber % 10;
int resultNumber = firstDigit + secondDigit;

Console.WriteLine("Сгенерированное число = " + randomNumber);
Console.WriteLine("Результирующее число = " + resultNumber);