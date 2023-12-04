// Задайте двуменый массив. Найдите элементы, у которых индексы
// четные и возвести их в квадрат

// 1234
// 4567
// 8910

// Матрица- табюлица размерностью m*n 

// int[x] => int[] одномерный массив
// int[x,y] => int[,] двумерный массив
// int[x,y.z] => int[,,] трехмерный массив

// int[,] CreateMatrix(int rows, int colums, int min, int max)
// {
//     int[,] matrix = new int[rows, colums];
//     // Матрица размером rows на colums
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++) //i < matrix.GetLength(0), строчки
//     {
//         // i, j, m, k
//         for (int j = 0; j < colums; j++) // столбцы j < matrix.GetLength(1)
//         {
//             matrix[i, j] = rand.Next(min, max + 1);

//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matr)
// {
//     //[rows, columns]
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]}\t"); // \t - это 4 пробела
//         }
//         Console.WriteLine();
//     }
// }

// void SquareElements(int[,] matr)
// {
//     //[rows, columns]
//     for (int i = 0; i < matr.GetLength(0); i+=2) // 0 -> 2 -> 4 -> ...
//     {
//         for (int j = 0; j < matr.GetLength(1); j+=2)
//         {
//             // if (i % 2 == 0 && j % 2 == 0)
//             // {
//                 matr[i, j] *= matr[i, j];
//             //     // matr[i, j] = matr[i, j] * matr[i, j]
//             // }
//         }

//     }
// }


// int[,] res = CreateMatrix(3, 4, 0, 10);
// // Таблица: 2 строчки, 4 столбца, элементы

// PrintMatrix(res); // матрица до умножения
// Console.WriteLine("Результат: ");
// SquareElements(res); // Само умножение
// PrintMatrix(res); // Матрица после умножения


// Задача 2. Задайте двумерный массив. Найдите сумму элементов, находящихся
// на главной диагонали с индексами (0; 0); (1;2) и т.д. [i = j]


// int MainDiagonalSum(int[,] matr)
// {
//     int sum = 0;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i == j) // Глав. диагональ 
//             {
//                 sum += matr[i, j]; // sum = sum + matr[i, j]
//             }
//         }
//     }
//     return sum;
// }

// int[,] res = CreateMatrix(4, 4, 0, 10);
// PrintMatrix(res); // матрица до умножения

// Console.WriteLine($"Сумма элементов на гл. диагонали:{MainDiagonalSum(res)}");

// Задача 3. Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.

using System.Numerics;

int[,] CreateMatrix(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    // Матрица размером rows на colums
    Random rand = new Random();
    for (int i = 0; i < rows; i++) //i < matrix.GetLength(0), строчки
    {
        // i, j, m, k
        for (int j = 0; j < colums; j++) // столбцы j < matrix.GetLength(1)
        {
            matrix[i, j] = rand.Next(min, max + 1);

        }
    }
    return matrix;
}
void PrintMatrix(int[,] matr)
{
    //[rows, columns]
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t"); // \t - это 4 пробела
        }
        Console.WriteLine();
    }
}
// Вернем одномерный массив вещ. чисел
double[] GetArrayWithMeans(int[,] matrix)
{
    double[] means = new double[matrix.GetLength(0)];
    // Размер массива со сред. арифм. строчки матрицы =
    // количеству строк 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double currentSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            currentSum += matrix[i, j]; // Здесь сумма элементво стр
        }
        double currentMean = currentSum / matrix.GetLength(1);
        // Сумма : количество столбцов
        means[i] = currentMean;
    }
    return means;
}
int[,] res = CreateMatrix(4, 4, 0, 10);
// Таблица: 2 строчки, 4 столбца, элементы: [0;10]
PrintMatrix(res); // Матрица выводится на экран
double[] means = GetArrayWithMeans(res);
Console.WriteLine($"Массив: { string.Join("; ", means)}");