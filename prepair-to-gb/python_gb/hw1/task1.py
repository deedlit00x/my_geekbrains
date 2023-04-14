# Задача 1. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и выводит название этого дня недели.
# 1 –> Понедельник
# 10 –> Нет такого дня
# 7 –> Воскресение


# 1 Вариант

user_input = int(input('Введите день недели: '))

if user_input <= 0 or user_input > 7:
    print(f'{user_input} -> Нет такого дня')
    print('Введите число в диапазоне от 1 до 7')
else:
    if user_input == 1:
        print(f'{user_input} -> Понедельник')
    elif user_input == 2:
        print(f'{user_input} -> Вторник')
    elif user_input == 3:
        print(f'{user_input} -> Среда')
    elif user_input == 4:
        print(f'{user_input} -> Четверг')
    elif user_input == 5:
        print(f'{user_input} -> Пятница')
    elif user_input == 6:
        print(f'{user_input} -> Суббота')
    elif user_input == 7:
        print(f'{user_input} -> Воскресение')

# 2 Вариант

# print('Введите число в диапазоне от 1 до 7')
# user_input = int(input('Введите день недели: '))
# day_list = ['', 'Понедельник', 'Вторник', 'Среда', 'Четверг', 'Пятница', 'Суббота', 'Воскресение']

# if user_input <= 0 or user_input > 7:
#     print(f'{user_input} -> Нет такого дня')
# else:
#     print(f'{user_input} -> {day_list[user_input]}')