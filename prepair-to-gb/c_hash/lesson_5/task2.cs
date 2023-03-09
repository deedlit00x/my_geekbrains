/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

*/

// Console.WriteLine($"Введите длину массива: ");
// int lenNum = Convert.ToInt32(Console.ReadLine()); 
// int minNum = -10;
// int maxNum = 10;


// void ArrayGen(int lenNum, int min, int max){
//     int res = 0;
//     int[] rangeNum = new int[lenNum];
//     Console.Write("Получившийся массив: ");
//     for (int i = 0; i <rangeNum.Length; i++ ){
//         rangeNum[i] = new Random().Next(min, max);
//         if (i != rangeNum.Length - 1){
//             Console.Write(rangeNum[i] + ", ");
//         } else if (i == rangeNum.Length - 1){
//             Console.Write(rangeNum[i] + ". \n");
//         }
//     }
//     for (int i = 0; i < rangeNum.Length; i++){
//         if (i % 2 != 0){
//                 res += rangeNum[i];
//         }
//     }
//     Console.Write($"Сумма элементов нечетных позиций: {res}");
// }

// ArrayGen(lenNum, minNum, maxNum);