
// // Console.WriteLine("Введите высоту треугольника: ");
// // int height = Convert.ToInt32(Console.ReadLine());



// // for (int k = 0; k < height; k++)
// // {

// //     for (int l = height; l > k; l--)
// //     {
// //         Console.Write("*");
// //     }
// //     Console.WriteLine();
// // }

// // for (int i = 0; i < height; i++)
// // {

// //     for (int j = 0; j <= i; j++)
// //     {
// //         Console.Write("*");


// //     }
// //             Console.WriteLine();
// // }
// // for (int k = 0; k < height; k++)
// // {

// //     for (int l = height; l > k; l--)
// //     {
// //         Console.Write("*");
// //     }
// //     Console.WriteLine();
// // }

// // for (int i = 0; i < height; i++)
// // {

// //     for (int j = 0; j <= i; j++)
// //     {
// //         Console.Write("*");


// //     }
// //             Console.WriteLine();
// // }
// // for (int k = 0; k < height; k++)
// // {

// //     for (int l = height; l > k; l--)
// //     {
// //         Console.Write("*");
// //     }
// //     Console.WriteLine();
// // }

// // for (int i = 0; i < height; i++)
// // {

// //     for (int j = 0; j <= i; j++)
// //     {
// //         Console.Write("*");


// //     }
// //             Console.WriteLine();
// // }


// Console.WriteLine("Введите высоту треугольника: ");
// int height = Convert.ToInt32(Console.ReadLine());



// for (int i = 0; i < height; i++)
// {

//     for (int l = height; l > i; l--)
//     {
//         Console.Write(" ");
//     }

//     for (int k = 0; k <= i; k++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("\n");

// for (int i = 0; i < height; i++)
// {

//     for (int l = height; l > i; l--)
//     {
//         Console.Write(" ");
//     }

//     for (int k = 0; k <= i; k++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }

// ----------------------------------------

// Тернарный оператор

// int a = 2; //Унарный ( 1 элемент )
// int b = 1;
// int c = a + b; // Бинарный (2 элемента)
// accessAllowed = enteredPassword == storedPassword ? true : false; Тернарный
// bool accessAllowed;

// string storedPassword = "qwerty";
// string enteredPassword = Console.ReadLine();

// accessAllowed = enteredPassword == storedPassword ? true : false; 
// Console.WriteLine(accessAllowed);

// int inputDate = Convert.ToInt32(Console.ReadLine());

// int outputData = inputDate < 0 ? 0 : inputDate;


// -------------------------------- 

// Одномерные массивы

// Тип_элементов_массива [] имя_массива;

// int[] array;

// array = new int[5];

// array[3] = 1;

//     Console.Write(array[3]);
// -------------------------------------
// int[] array = new int[5] {1,2,4,6,7};

// int[] array = new int[] {1,4,6,7};

// int[] array = new [] {1,4,6,7};

// int[] array = {1,4,6,7};

// int[] array = Enumerable.Repeat(5, 10).ToArray();

// Console.Write(array[3]);

// int[] myArray = { 1, 4, 6, 7, 109 };

// int result = 0;

// for (int i = myArray.Length -1; i >= 0; i--)
// {
//     Console.Write(myArray[i] + "\t");
// }
// for (int j = 0; j < myArray.Length; j++)
// {
//     if (myArray[j] % 2 == 0)
//     {
// result = result + myArray[j];
// // result += myArray[j];
//     }
//     else
//     {
//         Console.Write(myArray[j] + " не четный");
//     }
// }
// Console.WriteLine("Чётный" + result/2);

// using System.Security.Cryptography.X509Certificates;

// int[] myArray = { 20, 200, 6, 7, 109 };


// int min = myArray[0];
// for (int i = 1; i < myArray.Length; i++)
// {
//     if (myArray[i] > min)
//     {
//         min = myArray[i];
//     }
// }
// Console.WriteLine(min);

// Console.WriteLine("Сколько будет 2 + 2?");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number == 4)
// {
//     Console.WriteLine("Не плохо! А сколько будет 2 + 2 * 2 = ?");
//     int lastNumber = Convert.ToInt32(Console.ReadLine());
//     if (lastNumber == 6)
//     {
//         Console.WriteLine("Умница) Чем займёмся дальше?");
//     }
//     else
// {
//     Console.WriteLine("Сначала выполняется (*) и (/) Будь внимательнее ;) ");
// }

// }
// else
// {
//     Console.WriteLine("Тупица учись считать!!!");
// }

// --------------------------------

// int[] myArray = { 10, 20, 30, 50, 11, 15, 19, 14 };

// int result = myArray.Sum();
// Console.WriteLine(result);

// char [,] myArray = char [3,4]
