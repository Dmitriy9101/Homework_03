Задача 1. Задайте одномерный массив из 10 целых чисел от 1 до 100
Найдите количество элементов массива, значения которых лежат
в отрезке [20,90]

int size = 10;
int[] array = new int[size]; // Массив на 10 элементов
// В массиве 10 нулей: [0,0,0,0,0,0,0,0,0,0], 
int lastNumber = 0; // Итоговое число
for (int i = 0; i < array.Length; i++) // array.Length = size [i++ (i = i + 1)]- прогонит все элементы
{
    array[i] = new Random().Next(101); // 0-100
    if (array[i] >= 20 && array[i] <= 100)
    {
     lastNumber++;
    }
}
Console.Write($"массив: [{string.Join(" ",array)}]");
Console.Write($" => {lastNumber}");

Задача 2: Задайте массив на 10 целых чисел. Напишите программу,
 которая определяет количество чётных чисел в массиве.

int size = 10;
int[] array = new int[size];  
int lastNumber = 0; // Итоговое число
for (int i = 0; i < array.Length; i++) // array.Length = size [i++ (i = i + 1)]- прогонит все элементы
{
    array[i] = new Random().Next(101); // 0-100
    if (array[i] % 2 == 0)
    {
     lastNumber++;
    }
}
Console.Write($"массив: [{string.Join(" ",array)}]");
Console.Write($" => {lastNumber}");

Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
 Найдите разницу между максимальным и минимальным элементов массива. 

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

void mas(int a)
{
Random rand = new Random();
for (int i = 0; i < a; i++)
{
randomArray[i] = rand.NextDouble() * 100;
Console.Write($"[{randomArray[i]:F2}] ");
}

}

double raz(double[] randomArray)
{
double min = randomArray[0];
double max = randomArray[0];
int i = 1;
while (i < randomArray.Length)
{
if (max<randomArray[i])
max = randomArray[i];
if (min>randomArray[i])
min = randomArray[i];
i = i + 1;
}
return max-min;
}

mas(a);
Console.Write($"=> [{raz(randomArray):F2}]");

