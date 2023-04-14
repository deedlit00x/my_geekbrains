# Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
# 5 -> 2, 4
# 8 -> 2, 4, 6, 8

user_input = int(input('Введите число: '))
res = []

for el in range(1,user_input + 1):
    if el % 2 == 0:
        res.append(el)

print(f'{user_input} -> {res}')