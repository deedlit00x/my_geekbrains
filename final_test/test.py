def final_test():
    user_list = []
    result = []
    while True:
        tmp = (input("Введите текст с клавиатуры, для завершения оставьте поле пустым: "))
        if len(tmp) == 0:
            print("Ввод завершен!")
            break
        else:
            user_list.append(tmp)
            
    for el in user_list:
        if len(str(el)) <= 3:
            result.append(el)
    print(f"Вы ввели {user_list}, из них соответствуют параметрам: {sorted(result)}")

final_test()