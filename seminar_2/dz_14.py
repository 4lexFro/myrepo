# Задача 14: Требуется вывести все целые степени двойки 
# (т.е. числа вида 2k), не превосходящие числа N.
n = int(input('Введите число N: '))
d = 1
while d <= n:
    print (d, end = ' ')
    d = d * 2
    
    