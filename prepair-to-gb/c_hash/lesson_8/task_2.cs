/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

// // Console.WriteLine("введите размер квадратного массива: ");
// // int cubeArray = Convert.ToInt32(Console.ReadLine());

// int cubeArray = 3;
// int[,] numbers = new int[cubeArray, cubeArray];
// int minsum = Int32.MaxValue;
// int indexLine = 0;

// CreateArray2D(numbers);
// PrintArray(numbers);

// void CreateArray2D(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }
            
// void PrintArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]\n");
//     }
// }

// for (int i = 0; i < numbers.GetLength(0); i++){
//     int sum = 0;
//     for (int j = 0; j < numbers.GetLength(1); j++){
//         sum += numbers[i, j];
//     }
//     if (sum < minsum){
//         minsum = sum;
//         indexLine++;
//     }
// }

// Console.WriteLine($"Cтрока с наименьшей суммой елементов: {indexLine}");