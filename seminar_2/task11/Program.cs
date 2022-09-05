//1. Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

Random rand = new Random ();
int number = rand.Next(10,1000);
Console.WriteLine($"Сгенерировать случайное число: {number}");
int digit3 = number % 10;
int digit1 = number / 100;
//Console.WriteLine(digit1);
//Console.WriteLine(digit3);


System.Console.WriteLine("Новое число: " + digit1 +digit3);