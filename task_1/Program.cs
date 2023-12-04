// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, 
//сумма цифр которого чётная.

while (true)
{
    Console.Write("Введите целое число (или 'q' для выхода): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "q")// Проверяем, был ли введен символ 'q' для завершения программы
    {
        Console.WriteLine("Программа завершена.");
        break;
    }

    if (int.TryParse(input, out int number))// Пытаемся преобразовать введенное значение в целое число
    {
        if (IsSumOfDigitsEven(number))// Проверяем, является ли сумма цифр числа чётной
        {
            Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
            break;
        }
        else
        {
            Console.WriteLine($"Сумма цифр числа {number} нечётная.");
        }
    }
    else
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q' для выхода.");
    }
}


static bool IsSumOfDigitsEven(int number)// Функция для проверки, является ли сумма цифр числа чётной
{
    int sum = 0;

    while (number != 0)// Считаем сумму цифр числа
    {
        sum += number % 10;
        number /= 10;
    }

    return sum % 2 == 0;// Проверяем чётность суммы
}