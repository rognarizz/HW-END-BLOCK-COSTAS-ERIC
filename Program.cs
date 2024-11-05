using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string[] initialArray = Console.ReadLine().Split(' ');

        int shortStringCount = CountShortStrings(initialArray, 3);

        string[] createdArray = CreateNewArray(initialArray, shortStringCount, 3);

        PrintArray(createdArray);
    }

    static int CountShortStrings(string[] array, int maxLength)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= maxLength)
            {
                count++;
            }
        }
        return count;
    }

    static string[] CreateNewArray(string[] array, int count, int maxLength)
    {
        string[] resultArray = new string[count];
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= maxLength)
            {
                resultArray[index] = array[i];
                index++;
            }
        }
        return resultArray;
    }

    static void PrintArray(string[] array)
    {
        Console.WriteLine("Новый массив строк, длина которых <= 3 символа:");

        Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"'{array[i]}', ");
        }
        Console.Write("]");
    }
}