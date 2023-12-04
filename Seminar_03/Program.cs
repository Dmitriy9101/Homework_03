// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int temp = number;
// if (number >= 100)
// {

// while (number > 999)
// {
//     number /= 10;
// }
// Console.WriteLine($"Третья цифра от: {temp} = {number % 10}");
// }
// else
// {
// Console.WriteLine("Число имеет меньше 3-х цифр :)");
// }

// Строчка(String) - массив символов (Char)
// str = "Hello", str[]
// while (true) // true == true?
// {
//     Console.WriteLine("Введите данные: ");
//     string stringnumber = Console.ReadLine();
//      // Нужно проверить что введенная строчка
//     // состоит только из цифр
//     // int.TryParse(cтрочка, out int имя_переменной)
//     // "123" -> yes. "123HelloWorld" -> res = 0 
//     if (int.TryParse(stringnumber, out int result)) // true
//     {
//         if (stringnumber.Length >= 3) //result >= 100
//         {
//             Console.WriteLine($"3 цифра: от {stringnumber} = {stringnumber[2]}");
//             break;
//         }
//         else
//         {
//             Console.WriteLine("Число имеет меньше 3 цифр :)");
//         }
//     }
//     else
//     {
//         Console.WriteLine("В строчке есть другие символы!");
//     }
// }

// Задайте программу которая определяет присутствует ли
// заданное число в массиве. Программа должна выдать да/нет
// Примеры:
// [1 3 4 19 3] , 8 => No
// [-4 3 4 1], 3 => Yes

// Массив- набор данных который имеет опр тип, размер массива

// Массив на 8 рандомных элементов
int size = 8;
int[] array = new int[size]; // Массив на 8 элементов
// В массиве 8 нулей: [0,0,0,0,0,0,0,0], i++ (i = i + 1)
int numberForSearch = new Random().Next(11); //[0,10]
bool flagFound = false; //false - эдемент НЕ найден
// (начало, условие, увл. счетчика)
for (int i = 0; i < array.Length; i++) // array.Length = size
{
    array[i] = new Random().Next(21); // 0-20
    if (array[i] == numberForSearch)
    {
     flagFound = true;
     break; //Если элемент нашли, вывели "+" и цикл окончен
    }
}
Console.WriteLine(numberForSearch);
Console.WriteLine($"Массив: [{string.Join("; ",array)}]");
if (flagFound) // ==true
{
    Console.WriteLine($"Элемент {numberForSearch} Найдено");
}
else
{
    Console.WriteLine($"Элемент {numberForSearch} НЕ Найдено");
}


// Задайте массив из 10 элементов, заполненный числами из
// промежутка[-10, 10]. Замените отрицательные элементы на положительные,
//  а положительные на отрицательные
// Пример
// [1, 5 , 6]
// => [-1 5 -6]

// int size = 10;
// int[] array = new int[size];
// for (int i = 0; i < array.Length; i++) // array.Length = size
// {
//     array[i] = new Random().Next(-10, 11);  // -10 - 10
// }
// Console.WriteLine($"Массив ДО: [{string.Join("; ",array)}]");
// for (int i = 0; i < array.Length; i++)
// {
//     // array[i] = array[i] * -1;
//     array[i] *= -1;
// }
// Console.WriteLine($"Массив ПОСЛЕ: [{string.Join("; ",array)}]");

// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и тд.
// Результат запишите в новый массив
// Пример
// [ 1 2 3 4 2 3 ] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5 7] 

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// for (int i = 0; i < array.Length; i++) // array.Length = size
// {
//     array[i] = new Random().Next(-10, 11);  
// }
// Console.WriteLine($"Массив: [ {string.Join("; ",array)} ]");
// // [10, 20, 30] => [300, 20]
// int newSize = size / 2 + size % 2;
// int[] result = new int[newSize];
// for (int i = 0, j = size - 1; i < size / 2; i++, j--)
// {
//     result[i] = array[i] * array[j];
// }
// if (array.Length % 2 == 1) // Размер массива - нечетный
// {
//     result[newSize - 1] = array[size / 2]; // array[1]
//     // В посл. элемент массива кладем число БЕЗ пары
// }
// Console.WriteLine($"Результат: [ {string.Join("; ",result)} ]");

