// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. 
//Если число 1 не кратно числу 2, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

Console.WriteLine("Введите первое число");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе  первое число");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n2 != 0)
{

int mod =  n1 % n2;
if (mod == 0) 
{
    Console.WriteLine("Кратно");
}
else
{
  Console.WriteLine($"Не кратное, остаток {mod}");  
}
}
else
{
    Console.WriteLine("Нельзя делить на 0!");
}