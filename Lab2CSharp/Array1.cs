using System;

class Array1
{
    static void Main1(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть розмірність масиву:");
        int size = int.Parse(Console.ReadLine());

        OneDimensionalArray array = new OneDimensionalArray(size);

        Console.WriteLine("Введіть елементи масиву:");
        array.InputElements();

        Console.WriteLine("Введіть число, менше якого будуть замінені елементи:");
        int number = int.Parse(Console.ReadLine());

        array.ReplaceElementsWithNumber(number);

        Console.WriteLine("Результат за допомогою одновимірного масиву:");
        array.Print();
    }
}

class OneDimensionalArray
{
    private int[] array;

    public OneDimensionalArray(int size)
    {
        array = new int[size];
    }

    public void InputElements()
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    public void ReplaceElementsWithNumber(int number)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < number)
            {
                array[i] = number;
            }
        }
    }

    public void Print()
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
