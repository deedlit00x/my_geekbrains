/* Задача 10: Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Clear();

int num = 4;
string str = num.ToString();
Console.WriteLine(str[1]);

