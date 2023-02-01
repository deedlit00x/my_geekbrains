/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/ 

Console.Clear();
bool flag = false;

while (flag != true){
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    string str = num.ToString();

    if (str.Length < 3){
        Console.WriteLine("Вы ввели не трехзначное число, повторите ввод!");
        continue;
    } else {
        Console.WriteLine(str[2]);
        flag = true;
    }
}