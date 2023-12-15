
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
// int [] MyArray  = {2,4,6,9};
// string EndToStartArray(int start, int end)
// {
//     // Базовый случай

//     if (MyArray[start] == MyArray[end]) return "В массиве 1 элемент";

//     // Рекурсивный случай

//     return EndToStartArray(start,end - 1);
// }
// Console.WriteLine(EndToStartArray(MyArray[0],MyArray[MyArray.Length - 1]) + " ");

// 4! = 1*2*3*4 = 24

//     // 5 * 4* 3 * 2 * 1
//     // Базовый случай - выход из рекурсии
//     if (n == 1) return 5;
//     // Рекурсивный случай - логика программы

//     return n * FindFactorial(n - 1);
// }
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Factorial от числа {N} = {FindFactorial(N)}");
//     }
// }

// Задание 2
// int FindFactorial(int n)
// {
//     // 5! = 5 * 4
//     // n! = n * ... * 1
//     // Базовый случай - выход из рекурсии
//     if (n == 1) return 1;
//     // Рекурсивный случай - работу рекурсии 
//     return n * FindFactorial(n - 1);
// }
// Console.Write("Введите число N: ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Факториал от числа {M} = {FindFactorial(M)}");


// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// //start = M, end = N
// string PrintNumbers(int start, int end)
// {
//     // Базовый случай
//     if (start == end) return start.ToString();
//     // Рекурсивный случай
//     return start + " " + PrintNumbers(start + 1, end);
// }
// Console.WriteLine($"Целые числа от {M} до {N} = {PrintNumbers(N,N)}");

/* Задача 3: Задайте произвольный массив. Выведите его элементы,
 начиная с конца. Использовать рекурсию, не использовать циклы.
 */
Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] myArray = new int[size]; // Создали массив

for (int i = 0; i < size; i++) //Заполянем массив
{
    myArray[i] = new Random().Next(1, 10);

    Console.Write(myArray[i] + "\t");
}
Console.WriteLine();
Console.WriteLine();

int EndToStartArray(int[] array, int current = 0)
{
    if (current == array.Length)  
    return 0;

    else
    {
        int lastArray = array.Length;

        EndToStartArray(array, current--);
    return array[current] + array.Length;
    }
}
