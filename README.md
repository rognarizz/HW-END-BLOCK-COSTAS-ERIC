## HW-END-BLOCK-COSTAS-ERIC

# Программа фильтрации строк по длине

Эта программа имеющегося массива строк формирует новый массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры. Программа работает без использования коллекций, исключительно с массивами.

## Как это работает

### Ввод данных

Программа запрашивает у пользователя ввод массива строк через пробел. Полученный ввод разделяется на отдельные строки и сохраняется в массив `initialArray`.

```csharp
Console.WriteLine("Введите элементы массива через пробел:");
string[] initialArray = Console.ReadLine().Split(' ');
```

### Подсчет количества коротких строк

Функция `CountShortStrings` принимает массив строк и максимальную длину строки `(maxLength)`. Она подсчитывает количество строк, длина которых меньше либо равна `maxLength`.

```Csharp
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
```

### Создание нового массива
Функция `CreateNewArray` принимает исходный массив, количество коротких строк `(count)` и максимальную длину строки `(maxLength)`. Она создает новый массив `resultArray`, заполняя его строками, длина которых меньше либо равна `maxLength`.

```Csharp
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
```

### Вывод нового массива
Функция `PrintArray` принимает массив строк и выводит его элементы на экран.

```Csharp
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
```

### Основной метод

В основном методе `Main` происходит вызов всех функций по порядку: ввод массива, подсчет коротких строк, создание нового массива и вывод результата.

```Csharp
static void Main()
{
    Console.WriteLine("Введите элементы массива через пробел:");
    string[] initialArray = Console.ReadLine().Split(' ');

    int shortStringCount = CountShortStrings(initialArray, 3);

    string[] createdArray = CreateNewArray(initialArray, shortStringCount, 3);

    PrintArray(createdArray);
}
```