# Задача 32:
# Определить индексы элементов массива (списка), значения которых принадлежат 
# заданному диапазону (т.е. не меньше заданного минимума и не больше заданного максимума)

min = int(input("min: " ))
max = int(input("max: " ))
import random
list_1 = []
for _ in range(10):
    list_1.append(random.randint(-50, 50))
print(list_1)
list_2 = []
for i in range(len(list_1)):
     if list_1[i] >= min and list_1[i] <= max:
         list_2.append(i)
print(list_2)