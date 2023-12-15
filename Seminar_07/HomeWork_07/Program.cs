/* Задача 1: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.*/

//   Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// //start = M, end = N
// string PrintNumbers(int start, int end)
// {
//     // Базовый случай
//     if (start == end) return start.ToString();
//     // Рекурсивный случай
//     return start + " " + PrintNumbers(start + 1, end);
// }
// Console.WriteLine($"Целые числа от {M} до {N} = {PrintNumbers(M + 1,N - 1)}");

/*// Задача 2: Напишите программу вычисления функции Аккермана с 
помощью рекурсии. Даны два неотрицательных числа m и n.*/
//   Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());

// int ack(int m, int n)
// {
//     //Базовый случай
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return ack(m - 1, 1);
//     }
//     else
//     {
//         return (ack(m - 1, ack(m, n - 1)));
//     }
// }


// Console.WriteLine(ack(N,M));

/* Задача 3: Задайте произвольный массив. Выведите его элементы,
 начиная с конца. Использовать рекурсию, не использовать циклы.
 */
// Console.Write("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[] myArray = new int[size]; // Создали массив

// for (int i = 0; i < size; i++) //Заполянем массив
// {
//     myArray[i] = new Random().Next(1, 10);

//     Console.Write(myArray[i] + "\t");
// }
// Console.WriteLine();
// Console.WriteLine();

// static void EndToStartArray(int[] array, int current = 0)
// {
//     if (current == array.Length)  
//     return 1;

//     else
//     {
//         int lastArray = array.Length;

//         EndToStartArray(array, current--);
//     return array[current] + array.Length;
//     }
// }
