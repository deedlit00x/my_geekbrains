# Задача 2. В списке находятся названия фруктов. Выведите все фрукты, названия которых начинаются на заданную букву.
# а –> абрикос, авокадо, апельсин, айва.

fruit_list = ["Абрикос", "Хурма", "Дыня", "Яблоко", "Чупа", "Черешня", "Слива", "Путерия", "Персик", "Бананы", "Алыча"]

user_input = str.upper(input('Введите начальную букву: '))
result = []
for el in fruit_list:
    if el[0] == user_input[0]:
        result.append(el)
print(result)