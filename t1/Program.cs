// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать функцию Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16

Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());


int result = a;

for (int i = 1; i < b; i++)
{
    result *= a;
}
Console.Write(result);