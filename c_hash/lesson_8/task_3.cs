/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

*/

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] firstArray = new int[rows, columns];
// int[,] secondArray = new int[rows, columns];
// int[,] resultArray = new int[rows, columns];

// CreateArray2D(firstArray);
// CreateArray2D(secondArray);

// if (firstArray.GetLength(0) != secondArray.GetLength(1)){
//     Console.WriteLine(" Нельзя перемножить ");
//     return;
// }

// for (int i = 0; i < firstArray.GetLength(0); i++){
//     for (int j = 0; j < secondArray.GetLength(1); j++)
//     {
//         resultArray[i, j] = 0;
//         for (int k = 0; k < firstArray.GetLength(1); k++){
//             resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
//         }
//     }
// }

// void CreateArray2D(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray2D(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.Write("]\n");
//     }
// }

// Console.Write("\nПервая матрица: \n\n");
// PrintArray2D(firstArray);
// Console.Write("\nВторая матрица: \n\n");
// PrintArray2D(secondArray);
// Console.Write("\nРезультат перемножения: \n\n");
// PrintArray2D(resultArray);