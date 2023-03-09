/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.WriteLine($"Введите длину строки: ");
int lenNum = Convert.ToInt32(Console.ReadLine()); 
int [] nums = new int[lenNum];

void ArrayGen(int lenNum){
    for (int i = 0; i < lenNum; i++)
    {
        Console.WriteLine($"Введите число: ");
        nums[i] = Convert.ToInt32(Console.ReadLine());
    }
}

ArrayGen(lenNum);

void ArrPrint(int [] nums){
        Console.Write("Введеные числа пользователем: ");
        for (int i = 0; i <nums.Length; i++ ){
            if (i != nums.Length - 1){
                Console.Write(nums[i] + ", ");
            } else if (i == nums.Length - 1){
                Console.Write(nums[i] + ". \n");
            }
        }
    }
ArrPrint(nums);

void ArrFilter(int [] nums){
    int counter = 0;
    foreach(int i in nums){
        if (i > 0){
            counter++;
        }
    }
    Console.Write($"Кол-во чисел > 0 введеных пользователем : {counter}");
}
ArrFilter(nums);