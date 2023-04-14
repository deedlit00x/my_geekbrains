# Задача 3. Даны две строки. Посчитайте сколько раз каждый символ первой строки встречается во второй
# «one» «onetwonine» - o – 2, n – 3, e – 2

my_word = 'one'
word = 'onetwonine'
count = 0

for el in my_word:
    for let in word:
        if el == let:
            count += 1
    print(f'{el} - {count}')
    count = 0
