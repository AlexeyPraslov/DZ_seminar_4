//Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };// Создаем массив

        Console.WriteLine("Исходный массив: [" + string.Join(", ", array) + "]");// Выводим исходный массив

        ReverseArray(array); // Переворачиваем массив

        Console.WriteLine("Перевернутый массив: [" + string.Join(", ", array) + "]");// Выводим перевернутый массив
    }

    // Функция для переворачивания массива
    static void ReverseArray(int[] arr)
    {
        int length = arr.Length;

        for (int i = 0; i < length / 2; i++)
        {
            SwapElements(arr, i, length - 1 - i);// Обмениваем элементы массива с противоположными
        }
    }

    // Функция для обмена элементов массива
    static void SwapElements(int[] arr, int index1, int index2)
    {
        int temp = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = temp;
    }
}
