# Задача 1. Напишите программу, которая принимает на вход число N и выдает список факториалов для чисел от 1 до N.
# пусть N = 4 -> [ 1, 2, 6, 24 ] (1, 1*2, 1*2*3, 1*2*3*4)


import math
user_num = int(input('Введите число N: '))
result = []

for el in range(1, user_num):
    result.append(math.factorial(el))

print(result)