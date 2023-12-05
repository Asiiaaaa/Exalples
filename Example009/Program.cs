//Семинар 1
Console.Clear();
Console.Write("Введите число: ");
int s = Convert.ToInt32(Console.ReadLine());
// // s = "5"
Console.WriteLine(s + 5);
Console.WriteLine(s);

//--------------------------------------------------
//Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b*b)
   Console.WriteLine("yes");

else
   Console.WriteLine("no");

//Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2


Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = n * (-1);
 while (i <= n)
{
     Console.Write(i + " ");
     i ++;  // i = i + 1 
}
