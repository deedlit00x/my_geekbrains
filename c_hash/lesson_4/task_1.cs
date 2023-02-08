// Подсчитать сумму цифр в числе

// Не до конца понял смысл задачи, от 0 до самого числа суммировать 
// или же сложить числа в составе многозначного числа например: "324" (3+2+4) сделаю 2 варианта:

// 1 вариант:

// Console.Write("Введите число N: ");
// var N = int.Parse(Console.ReadLine()!);

// void Summ(int N){
//     int result = 0;
//     for (int i = 1; i <= N; i++){
//         result += i;
//     }
//     Console.WriteLine($"сумма цифр в числе {N} = {result}");
// }

// Summ(N);

// 2 вариант:

// Console.Write("Введите число N: ");
// var N = int.Parse(Console.ReadLine()!);

// void Summ(int N){
//     string str_N = N.ToString();
//     int result = 0;
//     for (int i = 0; i <= str_N.Length - 1; i++){
//         result += int.Parse(str_N[i].ToString());
//         Console.WriteLine(str_N[i]);
//     }
//     Console.WriteLine($"сумма цифр в числе {N} = {result}");
// }

// Summ(N);