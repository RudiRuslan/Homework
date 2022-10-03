// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// // в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16
// Console.Write("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// int result = 1;
// while (i<B+1)
// {
//     result = result * A;
//     i++;
// }
// Console.WriteLine(result);

// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int res = 0;
while (a>0)
{
    res = res + a % 10;
    a = a/10;
}
Console.WriteLine(res);
