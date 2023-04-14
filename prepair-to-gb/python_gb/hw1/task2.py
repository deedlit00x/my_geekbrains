# Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
# A (3,6); B (2,1) -> 5,09
# A (7,-5); B (1,-1) -> 7,21

import math

my_list = ('ax', 'ay', 'bx', 'by')
coords_list = []
for el in my_list:
    coords_list.append(float(input(f'Введите координату {el}: ')))

result = math.sqrt((coords_list[0] - coords_list[2]) ** 2 + (coords_list[1] - coords_list[3]) ** 2)
print(f'Растояние между точками A и B = {round(result, 2)}')