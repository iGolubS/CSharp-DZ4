// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)    2, 4 -> 16

// Console.Clear();
// Console.Write("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Math.Pow(A,B));



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11    82 -> 10    9012 -> 12

// В задаче не указано, как программа воспринимает отрицательные числа, оставляю как есть.

// Console.Clear();
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// while (num != 0)
// {
//     sum=num%10+sum;
//     num=num/10;
// }
// Console.WriteLine(sum);



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]    6, 1, 33 -> [6, 1, 33]

// В задаче не указано какие должны быть элементы, оставляю их без ограничений.

Console.Clear();
int[] array1 = new int[8];
Random rnd = new Random();
Console.Write ("Случайный массив из 8 элементов - ");
for ( int i = 0; i < 8; i++)
{
    array1[i] = rnd.Next();
    Console.Write(array1[i] + " ");
}