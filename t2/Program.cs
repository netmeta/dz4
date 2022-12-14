// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму чисел, являющиеся делителями этого числа !
// 452 -> 4+2 = 6
// 82 -> 2
// 9012 -> 3


Console.Write("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());

int Sumofnumber(int number)
{
    int sum = 0;

    for (int i = number; i > 0; i /= 10)
    {
        if (((i % 10) == 0)||(number % (i % 10) == 0))
        {
            sum += (i % 10);
        }
    }

    return sum;
}

int result = Sumofnumber(n);
Console.WriteLine(result);