//Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.



class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10];
        Random rnd = new Random();
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(100, 1000);
        }

        int evenCount = CountEvenNumbers(array);

        Console.WriteLine("Количество чётных чисел в массиве: " + evenCount);
    }

    static int CountEvenNumbers(int[] array)
    {
        int count = 0;

        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }
}
