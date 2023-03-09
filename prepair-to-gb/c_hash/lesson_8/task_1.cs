/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

*/

// Console.WriteLine("введите количество строк: ");
// int m_lines = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов: ");
// int n_col = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[m_lines, n_col];

// CreateArray2D(numbers);
// Console.WriteLine($"\nСозданный массив: \n");
// PrintArray(numbers);
// SortToLower(numbers);
// Console.WriteLine($"\nСозданный массив после сортировки по убыванию: \n");
// PrintArray(numbers);

// void CreateArray2D(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void SortToLower(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             for (int k = 0; k < array.GetLength(1) - 1; k++){
//                 if (array[i, k] < array[i, k + 1]){
//                     int tmp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = tmp;
//                 }
//             }
//         }
//     }
// }

// void PrintArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.Write("\n");

//     }
// }