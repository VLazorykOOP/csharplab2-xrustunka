using System;

class Array4
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть кількість рядків у масиві:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть кількість елементів у кожному рядку:");
        int m = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[n, m];

        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Рядок {i + 1}:");
            for (int j = 0; j < m; j++)
            {
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Створення нового масиву для зберігання мінімальних елементів кожного стовпця
        int[] minElements = new int[m];

        // Заповнення масиву minElements значеннями мінімальних елементів з кожного стовпця
        for (int j = 0; j < m; j++)
        {
            int min = array[0, j];
            for (int i = 1; i < n; i++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                }
            }
            minElements[j] = min;
        }

        // Виведення результатів
        Console.WriteLine("Мінімальні елементи в кожному стовпці:");
        for (int j = 0; j < m; j++)
        {
            Console.WriteLine($"Стовпець {j + 1}: {minElements[j]}");
        }
    }
}
