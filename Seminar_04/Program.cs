
// Console.Write("Введите цифру до 100 000: ");
// int number = Convert.ToInt32(Console.ReadLine ());
// int temp = number;
// int count = 0;
// while (number > 0)
// {
//     number /= 10;
//     count ++;
// }
// Console.WriteLine($"Количество цифр в числе {temp} = {count}");
// int[] digits = new int [count];
// for (int i = 0; i < digits.Length - 1; i--, i >= 0)
// {
//     digits[i] - number % 10;
//     number /= 10;
// }
// Методы:
// 1. void (процедуры, метод не возвращает)
// // 2. Не void (метод возвращает)
// using System.Reflection.Metadata;

// Создадим калькулятор, используя метод
// 2 числа, знак арифм. операции

// int Calculate(int a, int b, char Sign)
// {
//     if (Sign == '+')
//     {
//         return a + b; // отдал человеку сумму чисел
//     }
//     else if (Sign == '-')
//     {
//         return a - b; // отдал человеку разность чисел
//     }
//     else if (Sign == '*')
//     {
//         return a * b; // отдал человеку произведение чисел
//     }
//     else if (Sign == '/')
//     {
//         return a / b; // отдал человеку деление чисел
//     }
//     else
//     {
//         Console.WriteLine("Invalid input");
//         return 0;
//     }
// }
// // вызов метода
// int res = Calculate(2, 3, '+');
// Console.WriteLine(res); // 5
// Console.WriteLine(calculate(2,3, `*`)); // 6
// Console.WriteLine(calculate(2,3, `/`)); // 0
// Console.WriteLine(calculate(2,3, `-`)); // -1
// Console.WriteLine(calculate(2,3, `.`)); // Invalid Input, 0




// int[] CreateArray(int size, int minRandom, int maxRandom) // Созадём массив
// {
//     int[] array = new int[size]; //Создаем массив на size элементов
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minRandom, maxRandom + 1);
//     }
//     return array;
// }

// int GetCount (int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 7 == 0 && arr[i] % 10 ==1)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// // Вызов метода
// int[] result = CreateArray(5000, 21, 100);
// // Получим массив на 10 элементов, эл [-10, 50]
// Console.WriteLine($"[ {string.Join("; ", result)} ]");
// Console.WriteLine($"Total: {GetCount(result)}");

// Заполните массив на N (вводится с консоли, не более 8)
// случайных чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший на последнем.

// int ConvertArrayToInteger (int [] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
        
//     }
// }

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size > 8)
{
    Console.WriteLine("Больше 8 элементов в массиве быть не может");
    return; // на данной строчке программа завершится
}
// int[] array = 1(int x, int y);
// int[] array = new int[size, 0, 9];
int[] array = CreateArray(size, 0, 9);

Console.WriteLine($"[ {string.Join("; ", array)} ]");
