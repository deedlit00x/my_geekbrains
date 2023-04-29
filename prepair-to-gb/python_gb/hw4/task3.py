# Задача 3. Задайте список случайных чисел от 1 до 10. Посчитайте, сколько всего совпадающих элементов есть в списке. Удалите все повторяющиеся элементы.
# [1, 4, 2, 3, 4, 6, 1, 7] => 4 элемента совпадают Список уникальных элементов [1, 4, 2, 3, 6, 7]

from random import randint
my_list =  [randint(1, 10) for i in range(10)]
count = 0
unique_nums = []

for el in my_list:
    if my_list.count(el) >= 2:
        count += 1
    elif my_list.count(el) < 2:
        unique_nums.append(el)
if count <= 4:
    print(f'в списке {my_list} => {count} элемента совпадают \nСписок уникальных элементов {unique_nums}')
elif count >= 5:
    print(f'в списке {my_list} => {count} элементов совпадают \nСписок уникальных элементов {unique_nums}')