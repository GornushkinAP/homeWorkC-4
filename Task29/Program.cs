// Задача 29: Напишите программу, которая задаёт массив из 8 элементов в диапазоне от 10 до 1000 и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int randomNumber = new Random().Next(10, 100);

int[] numbers = new int[8];


Random randomArray = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = randomArray.Next(10, 1001);
}


Console.WriteLine("Элементы массива: ");
Console.Write("[");
foreach (int number in numbers)
{
    Console.Write(number + " ");
}
Console.Write("]");
Console.WriteLine();