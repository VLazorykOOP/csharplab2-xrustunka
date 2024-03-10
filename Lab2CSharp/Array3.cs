using System;

class Array3
{
    static void Main2(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть розмірність масиву (n x n):");
        int n = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[n, n];

        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int sum = 0;
        int count = 0;

        for (int i = 1; i < n; i++) // Проходимо по рядках, починаючи з другого
        {
            for (int j = 0; j < i; j++) // Проходимо по елементах рядка, що знаходяться нижче головної діагоналі
            {
                if (array[i, j] % 2 == 0) // Перевіряємо, чи елемент парний
                {
                    sum += array[i, j]; // Додаємо його до суми
                    count++; // Збільшуємо лічильник
                }
            }
        }

        if (count > 0) // Перевіряємо, чи є парні елементи нижче головної діагоналі
        {
            double average = (double)sum / count; // Обчислюємо середнє арифметичне
            Console.WriteLine($"Середнє арифметичне парних елементів, розташованих нижче головної діагоналі: {average}");
        }
        else
        {
            Console.WriteLine("В масиві немає парних елементів, розташованих нижче головної діагоналі.");
        }
    }
}
