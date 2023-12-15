// 06.12.2023
// using System.Collections;

// int[] Array = { 3, 4, 5, 10 };
// // for (int i = 0; i < Array.Length; i++)
// // {
// //  Array[] = Next.Random(ToString())
// // }
// for (int i = 0; i < Array.Length; i++)
// {
//     Console.Write(Array[i]);
//     Console.Write("\t");

// }
// Console.Write("\n");
// Console.WriteLine(Array.Length + " элемента");

// --------------------------------------

// КОНВЕРТАЦИЯ СТРОКИ В ЧИСЛО

// string str = "5, 4, 6";

// int a = Convert.ToInt32(str);

// Console.Write(a);

// string str = "1, 9, 10,2";
// double a = Convert.ToDouble(str);
// Console.Write(a);

// string str = "4";
// int.Parse(str);

// ---------------------------------

// string a = Console.ReadLine();

// switch (a)
// {
//     case "+":
//         Console.WriteLine("Вы ввели число 1");
//         break;
//     case "-":
//         Console.WriteLine("Вы ввели число 1");
//         break;
//     default:
//         Console.WriteLine("Вы ввели хуйню");
//         break;


// }

// Console.WriteLine("Введите начало отрезка");
// int begining = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите конец отрезка");
// int limit = Convert.ToInt32(Console.ReadLine());
// int endNumber = 0;
// int dontNumber = 0;
// while (begining <= limit)
// {
//     if (begining % 2 == 0)
//     {


//         endNumber++;
//     }
//     else
//     {


//         dontNumber++;
//     }
//     begining++;
// }
// Console.WriteLine("чётных" + endNumber);
// Console.WriteLine("не четных " + dontNumber);

// ------------------------------------

// for

// for (int i = 0; i < 10; i++)
// {
// Console.WriteLine(i);
// }
using System.Data;
using System.Runtime.CompilerServices;
// Console.Write("Введите максимальную цифру цикла: ");
// int limit = Convert.ToInt32(Console.ReadLine());
// int x = 2;
// for (int i = 0; i < 5; i++)
// {
//     if(i==2)
//     {
//         continue;
//     }
//     // x = x * 2;
//     // // Console.WriteLine("Итого " + x);
//     // int y = +x;
//     Console.WriteLine("Итого " + y);
// }

// ------------------------

// Вложенные циклы


// Console.Write("Введите высоту прямоугольника: ");
// int height = int.Parse(Console.ReadLine());
// Console.Write("Введите ширину прямоугольника: ");
// int width = int.Parse(Console.ReadLine());

// for (int j = 0; j < height; j++)
// {



//     for (int i = 0; i < width; i++)
//     {
//         Console.Write("+");
//     }
// Console.WriteLine();

// }


// for (int i = 0; i < 2; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         Console.Write("+");

//     }
//     Console.WriteLine();
//     for (int q = 0; q < 4; q++)
//     {
//         Console.Write("+");

//     }
//         Console.WriteLine();
//     for (int k = 0; k < 3; k++)
//     {
//         Console.Write("+");

//     }
//     Console.WriteLine();

//     for (int k = 0; k < 2; k++)
//     {
//         Console.Write("+");

//     }
//         Console.WriteLine();

// }

Console.Write("Введите высоту треугольника: ");
int height = int.Parse(Console.ReadLine());


// for (int i = 0; i < height; i++)
// {


// for (int j = 0; j <= i; j++)
// {
// Console.Write("*");
// }
// Console.WriteLine();
// }