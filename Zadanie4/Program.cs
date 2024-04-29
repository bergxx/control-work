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