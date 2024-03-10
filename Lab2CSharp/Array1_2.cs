using System;

class TwoDimensionalArrayProgram
{
    static void Main2(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть кількість рядків:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть кількість стовпців:");
        int columns = int.Parse(Console.ReadLine());

        TwoDimensionalArray array = new TwoDimensionalArray(rows, columns);

        Console.WriteLine("Введіть елементи масиву:");
        array.InputElements();

        Console.WriteLine("Введіть число, менше якого будуть замінені елементи:");
        int number = int.Parse(Console.ReadLine());

        array.ReplaceElementsWithNumber(number);

        Console.WriteLine("Результат за допомогою двовимірного масиву:");
        array.Print();
    }
}

class TwoDimensionalArray
{
    private int[,] array;

    public TwoDimensionalArray(int rows, int columns)
    {
        array = new int[rows, columns];
    }

    public void InputElements()
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public void ReplaceElementsWithNumber(int number)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < number)
                {
                    array[i, j] = number;
                }
            }
        }
    }

    public void Print()
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
