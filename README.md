# Фильтрация строк по длине в C#

Эта программа, написанная на языке C#, принимает массив строк и создает новый массив, содержащий только те строки, длина которых не превышает 3 символа.

## Описание решения

Программа сначала запрашивает ввод строк через консоль. Затем введенные строки разделяются на отдельные элементы массива с использованием метода `Split()` и заданных разделителей (, и пробелы). Затем вызывается функция `FilterStrings()`, которая фильтрует строки по их длине, оставляя только те, которые имеют длину не более 3 символов.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строки через запятую:");
        string[] inputArray = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string[] outputArray = FilterStrings(inputArray);

        Console.WriteLine("Исходный массив: " + string.Join(", ", inputArray));
        Console.WriteLine("Результат: " + string.Join(", ", outputArray));
    }

    static string[] FilterStrings(string[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                count++;
            }
        }

        string[] result = new string[count];
        int index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                result[index++] = arr[i];
            }
        }

        return result;
    }
}
```

## Примеры

**Входные данные:** [“Hello”, “2”, “world”, “:-)”]

**Ожидаемый вывод:** [“2”, “:-)”]


**Входные данные:** [“1234”, “1567”, “-2”, “computer science”]

**Ожидаемый вывод:** [“-2”]


**Входные данные:** “Russia”, “Denmark”, “Kazan”]

**Ожидаемый вывод:** []