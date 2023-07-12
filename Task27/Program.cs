// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12

Console.Write("Здравствуйте. Введите целое число: ");
string input = Console.ReadLine(); 

int number;
if (int.TryParse(input, out number)) 
{
    int sum = CalculateDigitSum(number); 

    Console.WriteLine("Сумма цифр в числе: " + sum);
    Console.WriteLine("Досвидания.");
}
else
{
    Console.WriteLine("Ошибка! Введите корректное число.");
}


static int CalculateDigitSum(int number)
{
    int sum = 0;

    while (number != 0)
    {
        int digit = number % 10; 
        sum += digit; 
        number /= 10; 
    }

    return sum;
}
