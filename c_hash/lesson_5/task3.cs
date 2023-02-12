/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

*/
// 1 вариант
// Console.WriteLine($"Введите длину массива: ");
// int lenNum = Convert.ToInt32(Console.ReadLine()); 
// int minNum = 1;
// int maxNum = 100;

// void ArrayGen(int lenNum, int min, int max){
//     int[] arrNum = new int[lenNum];
//     Console.Write("Получившийся массив: ");
//     for (int i = 0; i <arrNum.Length; i++ ){
//         arrNum[i] = new Random().Next(min, max);
//         if (i != arrNum.Length - 1){
//             Console.Write(arrNum[i] + ", ");
//         } else if (i == arrNum.Length - 1){
//             Console.Write(arrNum[i] + ". \n");
//         }
//     }
//     int arrMin = arrNum.Min();
//     int arrMax = arrNum.Max();
//     int res = arrMax - arrMin;
//     Console.Write($"Max = {arrMax}, Min = {arrMin}, разница этих значений: {res}");
// }


// 2 вариант

// ArrayGen(lenNum, minNum, maxNum);

// Console.WriteLine($"Введите длину массива: ");
// int lenNum = Convert.ToInt32(Console.ReadLine()); 
// int minNum = 1;
// int maxNum = 100;

// void ArrayGen(int lenNum, int min, int max){
//     int[] arrNum = new int[lenNum];
//     Console.Write("Получившийся массив: ");
//     for (int i = 0; i <arrNum.Length; i++ ){
//         arrNum[i] = new Random().Next(min, max);
//         if (i != arrNum.Length - 1){
//             Console.Write(arrNum[i] + ", ");
//         } else if (i == arrNum.Length - 1){
//             Console.Write(arrNum[i] + ". \n");
//         }
//     }
//     int arrMin = arrNum[0];
//     int arrMax = 0;
//     foreach (int i in arrNum){
//         if (i > arrMax){
//             arrMax = i;}
//         else if (arrMax <= arrMin){
//             arrMin = i;
//         }
//     }
//     int res = arrMax - arrMin;
//     Console.Write($"Max = {arrMax}, Min = {arrMin}, разница этих значений: {res}");
// }

// ArrayGen(lenNum, minNum, maxNum);