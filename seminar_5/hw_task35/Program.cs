//Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].



int N=123;
int[] arr=new int[N];
Random random=new Random();
for(int i=0;i<arr.Length;i++)
arr[i]=random.Next(0,10);
for(int i=0;i<arr.Length;i++)
System.Console.Write($"{arr[i],4}");

int count=0;
for(var i=0; i<arr.Length;i++)
{
if(i>10 && i<99)
count++;
}
System.Console.WriteLine();
System.Console.WriteLine(count);
