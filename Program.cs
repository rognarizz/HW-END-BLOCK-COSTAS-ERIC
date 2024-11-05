using System;
using Internal;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string[] initialArray = Console.ReadLine().Split(' ');

        int shortStringCount = CountShortStrings(initialArray, 3);

        string[] createdArray = CreateNewArray(shortStringCount);

        PrintArray(createdArray);
    }

    static int CountShortStrings(string[] array, int maxLength)
    {
        int count = 0;
        for (int i = 0; i < initialArray.Length; i++)
        {
            if (initialArray[i].Length <= 3)
            {
                count++;
            };
        }
    }

    static string[] CreateNewArray(string[] array)
    {
        string[] resultArray = new string[count];
        int index = 0;

        for (int i = 0; i < initialArray.Length; i++)
        {
            if (initialArray[i].Length <= 3)
            {
                resultArray[index] = initialArray[i];
                index++;
            }
        }
        return resultArray;
    }

    static void PrintArray(string[] array)
    {
        Console.WriteLine("Новый массив строк, длина которых <= 3 символа:");
        foreach (string str in resulArray)
        {
            Console.WriteLine(str);
        }
    }
}

