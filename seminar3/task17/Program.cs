//Напишите программу, которая принимает на вход 
//координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
//в которой находится эта точка.

Console.WriteLine("Введите коортдинату точки по х");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коортдинату точки по y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
   Console.WriteLine("Точка находиться в первой координатной четверти");
}
else if (x < 0 && y > 0)
{
Console.WriteLine("Точка находиться во второй  координатной четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находиться в третьей координатной четверти");
}
else if (x > 0 && y < 0)
{
   Console.WriteLine("Точка находиться в четвертой координатной четверти"); 
}
else 
{
    Console.WriteLine("Введена нулевая координата по x и/или y"); 
}
