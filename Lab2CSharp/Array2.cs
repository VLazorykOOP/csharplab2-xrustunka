using System;

class Array2
{
    static void Main2(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть розмірність масиву:");
        int size = int.Parse(Console.ReadLine());

        double[] array = new double[size];

        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < size; i++)
        {
            array[i] = double.Parse(Console.ReadLine());
        }

        // Знаходимо мінімальний елемент у масиві
        double min = array[0];
        for (int i = 1; i < size; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }

        // Виводимо номери всіх мінімальних елементів
        Console.WriteLine("Номери всіх мінімальних елементів:");
        for (int i = 0; i < size; i++)
        {
            if (array[i] == min)
            {
                Console.WriteLine(i);
            }
        }
    }
}
