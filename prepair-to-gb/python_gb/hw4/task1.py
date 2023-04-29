# Задача 1. Задайте список случайных чисел от 1 до 10, выведите все элементы больше 5. Используйте для решения лямбда-функцию.
# 2, 3, 4, 6, 7, 8 -> 6, 7, 8

from random import randint
my_list =  [randint(1, 10) for i in range(10)]
result = []

for el in my_list:
    if el > 5:
        result.append(el)

print(f'{my_list} -> {result}')