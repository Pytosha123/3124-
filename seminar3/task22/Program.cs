﻿//Задача 22: Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write(i * i + " ");
    }

}

else
{
   Console.WriteLine("number должно быть больше 0!"); 
}