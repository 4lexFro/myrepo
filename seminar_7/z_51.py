# Задача 51
# Напишите функцию same_by(characteristic, objects), которая проверяет, все ли объекты имеют 
# одинаковое значение некоторой характеристики, и возвращает True, если это так. Если значение 
# характеристики для разных объектов отличается – то False. Для пустого набора объектов,
# функция должна возвращать True. Аргумент characteristic – это функция, которая принимает
# объект и вычисляет его характеристику.
# Пример 1
# =================
# Ввод
# values = [0, 2, 10, 6]
# if same_by(lambda x: x % 2, values):
# print('same')
# else:
# print('different')
# ----------------------
# Вывод: same
# ====================
# Пример 2
# Ввод
# values = [1, 2, 3, 4]
# if same_by(lambda x: x % 2, values):
# print('same')
# else:
# print('different')
# ------------------------------
# Вывод: different

def same_by(characteristic, objects):
    new = list(filter(characteristic, objects))
    print(new)

    if new == objects:
        return True
    return False


def char(x):
    return x % 2 == 0


values = [2, 4, 5, 6, 7, 8, 9, 10]
print(same_by(char, values))