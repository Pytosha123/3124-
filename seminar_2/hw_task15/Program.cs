// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нен

   
Console.WriteLine("Введите номер дня недели:");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7)
{
    Console.WriteLine("(этот день недели выходной) -> да");
}
else if (number < 6 )
{
  Console.WriteLine("(Этот день недели  не выходной) -> нет"); 
}
else if (number < 6 || number > 7)
{
   Console.WriteLine("Это не день недели");
}