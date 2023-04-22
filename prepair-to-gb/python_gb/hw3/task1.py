# Задача 1. Создайте список. Запишите в него N первых элементов последовательности Фибоначчи.
# 6 –> 1 1 2 3 5 8 

def fibb():
    fib_res = []
    f1 = f2 = 1
    i = 0
    n = 12
    while i < n:
        f1, f2 = f2, f1 + f2
        fib_res.append(f2)
        i += 1
    return fib_res


result = []
tmp = fibb()
print(tmp)
user_inp = int(input('Введите число для отсечения последовательности Фибоначчи: '))
i = 0

while i != user_inp:
    result.append(tmp[i])
    i += 1

print(result)