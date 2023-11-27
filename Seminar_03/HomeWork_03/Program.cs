// Задайте одномерный массив из 10 целых чисел от 1 до 100
// Найдите количество элементов массива, значения которых лежат
// в отрезке [20,90]
int size = 10;
int[] array = new int[size];
for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(1, 101); 
}
Console.WriteLine($"[{string.Join("; ",array)}]");
