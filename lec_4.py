# С одной переменной:
#=============================

# def calc1(a):
#     return a+a

# def calc2(a):
#     return a*a

# def math(operation, x):
#     print(operation(x))
    
# math(calc1, 5)    

# С несколькими  переменными:
#===================================

# def calc1(a, b):
#     return a+b

# def calc2(a, b):
#     return a*b

# def math(operation, x, y):
#     print(operation(x, y))
    
# math(calc2, 5, 45)    

# Lambda функции:
#==========================

# Вместо def calc2(a, b):
#      return a*b 
# Пишем  calc2 = lambda a, b: a*b и затем
# в math(lambda a, b: a*b, 5, 45)

# def math(operation, x, y):
#     print(operation(x, y))
    
# math(lambda a, b: a*b, 5, 45)  


# 1. В списке хранятся числа. Нужно выбрать только чётные числа и составить
# список пар (число; квадрат числа).
# Пример: 1 2 3 5 8 15 23 38
# Получить: [(2, 4), (8, 64), (38, 1444)]

# data = [1, 2, 3, 5, 8, 15, 23, 38]
# res = list()

# for i in data:
#     if i % 2 == 0:
#         res.append((i, i**2))
# print(res) 
       
#Теперь эта задача через lambda функции:

# def select(f, col):
#     return[f(x) for x in col]

# def where(f, col):
#     return[x for x in col if f(x)]

# data = [1, 2, 3, 5, 8, 15, 23, 38]
# res = select(int,data)
# print (res)
# res = where(lambda x: x % 2 == 0, res)
# print (res)
# res = list(select(lambda x: (x, x**2), res))
# print (res)

#Функция map :
#===================

# list1 = [x for x in range(1, 20)]
# print(list1)
# # Теперь напишем,чтобы преобразовать наш список в список, где к каждому значению
# # прибавляется 10.

# list1 = list(map(lambda x: x + 10, list1))
# print(list1)

# Задача: C клавиатуры вводится некий набор чисел, в качестве разделителя
# используется пробел. Этот набор чисел будет считан в качестве строки. Как
# превратить list строк в list чисел?

# data = '15 156 96 3 5 8 52 5'
# print(data)

# data = data.split()
# print(data)
# Теперь через map:

# data = '15 156 96 3 5 8 52 5'
# data = list(map(int, data.split()))
# print(data)
