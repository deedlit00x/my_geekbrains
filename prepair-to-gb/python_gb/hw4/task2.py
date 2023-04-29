# Задача 2. Дан список случайных чисел. Создайте список, в который попадают числа, 
# описывающие случайную возрастающую последовательность. Порядок элементов менять нельзя.
# [1, 5, 2, 3, 4, 6, 1, 7] => [1, 2, 3] или [2, 7] или [4, 6, 7] и т.д.

from random import randint
my_list =  [randint(1, 10) for i in range(10)]
result = []

for i in range(len(my_list)):
        if my_list[i] == max(my_list[:i+1:]) and my_list[i] not in result:
            result.append(my_list[i])

print(f'{my_list} => {result}')