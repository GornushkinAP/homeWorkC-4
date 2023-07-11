// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine($"Добрый вечер.");
Console.Write("Введите число A: ");
double A = double.Parse(Console.ReadLine());

Console.Write("Введите степень B: ");
double B = double.Parse(Console.ReadLine());

double result = 1;

if (B >= 0 && Math.Floor(B) == B)
{
    for (int i = 0; i < Math.Abs(B); i++)
    {
        result *= A;
    }
}
else
{
    B *=-1;
    result = Math.Pow(A, B);
}

Console.WriteLine($"Результат: {result}");
Console.WriteLine($"Досвидания.");
