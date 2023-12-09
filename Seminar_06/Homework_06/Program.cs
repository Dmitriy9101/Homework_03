

// char[,] CreateMatrix(char rows, char colums, char min, char max)
// {
//     string[,] matrix = new string[rows, colums];
//     // Матрица размером rows на colums
//     Random rand = new Random();
//     for (char i = 0; i < rows; i++) //i < matrix.GetLength(0), строчки
//     {
//         // i, j, m, k
//         for (char j = 0; j < colums; j++) // столбцы j < matrix.GetLength(1)
//         {
//             i = Convert.ToInt16();
//             matrix[i, j] = rand.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// Задача 1: Задайте двумерный массив символов (тип char [,]).
//  Создать строку из символов этого массива.

// Console.WriteLine("Введите размеры массива ");
// // string i = Console.ReadLine();
// // string j = Console.ReadLine();


// char[,] = m (char i, char j, char min, char max)
// {}
// char*** create(int num){
//     char *** temp = (char ***) malloc(num * sizeof(char **));
//     for (int i=0; i < num; i++) {
//         temp[i] = (char **) malloc(num * sizeof(char*));
//         for (int j = 1; j < num; j++)
//             temp[i][j] = (char *) malloc(num * sizeof(char*));   
//     }
//     return temp;
// }