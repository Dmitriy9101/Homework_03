//Комментарий

// /
// "12"
// Console.WriteLine("12" + "12"); // =1212
// Convert.ToInt32("12"); // =12+12 = 24
// Тип данных Имя переменной= значение;
// int number = 5; // number = 5
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// //result- это number возведённый в квадрат
// int result = number * number;

// печатаем наш результат
// Console.Write("Результат: " + result);
// Console.Write($"Результат: {result}");
//$ "Текст {переменная} текст"


// int temp = 25;
// if(temp >= 10 && temp < 15) // && обязательное условире
// { //начало (Else if- пока не подойдёт одно)
// Console.WriteLine("Куртку");
// }//Конец
// else if(temp > 15 && temp <= 20)
// { //начало
// Console.WriteLine("Легкую Куртку");
// }//Конец
// else if(temp > 20)
// { //начало
// Console.WriteLine("Кепку");
// }//Конец

// Задача 3. Напишите программу, которая будет выдавать 
//название дня недели по заданному номеру
// 3-> Среда
// 5-> Птяница
// camelCase: 1 буква - маленькая, следующее слово
// начинается с большой буквы
// Console.Write("Введите номер дня недели: ");
// int numberOfDays = Convert.ToInt32(Console.ReadLine());
// // "==" - проверка на равенство ( 5 == 5 => true)
// if (numberOfDays == 1) // В numberOfDays лежит цифра 1
// {
//      Console.WriteLine("Понедельник");
// }
// else if (numberOfDays == 2)
// {
//      Console.WriteLine("Вторник");
// }
// else if (numberOfDays == 3)
// {
//      Console.WriteLine("Среда");
// }
// else if (numberOfDays == 4)
// {
//      Console.WriteLine("Четверг");
// }
// else if (numberOfDays == 5)
// {
//      Console.WriteLine("Пятница");
// }
// else if (numberOfDays == 6)
// {
//      Console.WriteLine("Суббота");
// }
// else if (numberOfDays == 7)
// {
//      Console.WriteLine("Воскресенье");
// }
// else // Все случаи, когда numberOfDays != от 1 вкл до 7 вкл
// {
//      Console.WriteLine("Такого дня недели нет");
// }

// Задача 5. Напишите программу, которая на вход
// принимает одно число N, а на выходе показывает
// все целые чиисла в промежутке от -N до N

// Console.Write("Введите Число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// // 5 *(- 1)= -5
// if (N < 0)
// {
//     N *= -1;
// }

// int negativeN = N * -1; // 5* -1 = -5
// // N=2
// while (negativeN <= N)  // negN = -2 -1 0 1 2
// {
//     Console.Write(negativeN + " "); // -2
//     // negativeN++; //Инкремент: Увл. negativeN на 1(negativeN)
//     negativeN += 1;
// }
