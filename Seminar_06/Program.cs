// int[] myArray = { 1, 3, 5, 6 };
// "1" + "2" = "12"
// indexes = [row,column]

// cтрочка- массив символов, символ char
// [a b c d] = > abcd

// string CharArray(char[,] array);
// {
//     string result = String.Empty; // указываем пустую строчку ""
//     for (int i = 0; i < 5; i++)
//     {
//         for (int j = 0; j < 5; j++)
// }
// char[,] array = { "H", "E", "L", "L", "O" };
// string result = CharArray(chars);
// Console.WriteLine($"Result: {result}");

int[,] myArr = new int[4, 5];

Random ran = new Random();

// Инициализируем данный массив
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 5; j++)
    {
       myArr[i, j] = ran.Next(1, 15);
       Console.Write("{0}\t", myArr[i, j]);
    }
    Console.WriteLine();
}