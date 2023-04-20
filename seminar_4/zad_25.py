# Задача №25. Решение в группах

# Напишите программу, которая принимает на вход
# строку, и отслеживает, сколько раз каждый символ
# уже встречался. Количество повторов добавляется к
# символам с помощью постфикса формата _n.

# Input: a a a b c a a d c d d
# Output: a a_1 a_2 b c a_3 a_4 d c_1 d_1 d_2

# Для решения данной задачи используйте функцию
# .split()

# 1 решение:

# str = 'a a a b c a a d c d d'
# x = str.split(' ')
# y = dict().fromkeys(x, 0)
# #print(y)
# for i in x:
#     if y[i] == 0:
#         print(i, end = ' ')
#     else:
#         print(f'{i}_{y[i]}', end = ' ')
#     y[i] += 1
        
# 2 решение:

stroka = input().split()
result = {}
for i in stroka:
    if i in result:
        print(f'{i}_{result[i]}', end=' ')
    else:
        print(i, end=' ')
    result[i] = result.get(i, 0) + 1 # get - если нет ключа (буква появляется первый раз)
# то возвращает 0, если буква появляется во второй раз,
# то возвращает ключ - i




    

