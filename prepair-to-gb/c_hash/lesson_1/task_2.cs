Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
/* 

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int a = 9;
int b = 10;
int c = 7;

if ((a > b) & (a > c)){
    Console.WriteLine($"max = {a}");
} else if ((a < b) & (b > c)){
    Console.WriteLine($"max = {b}");
} else {
    Console.WriteLine($"max = {c}");
};