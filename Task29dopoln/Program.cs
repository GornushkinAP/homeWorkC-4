// Задача 29: Напишите программу, в которой пользователь задаёт массив из 8 элементов 
// и затем программа выводит их на экран.

int[] array = new int[8];

Console.WriteLine("И снова Здравствуйте. Введите элементы массива:");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Элемент {i + 1}: ");
    if (int.TryParse(Console.ReadLine(), out int input))
    {
        array[i] = input;
    }
    else
    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
        i--;
    }
}

Console.WriteLine("Введенный массив:");
Console.Write("[");
foreach (int element in array)
{
    Console.Write(element + " ");
}
Console.Write("]");
Console.WriteLine("Досвидания.");