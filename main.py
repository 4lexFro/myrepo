#Комментирование:
#С помощью #, ''' выше ''' ниже , выделить и потом ctrl+k ctrl+c
#Раскомментить ctrl+k ctrl+u
# a = 6
# b = 4.65
# c = 'hello'
#Интерполяция:
#print(f'{a} - {b} - {c}')
#print('{} - {} - {}'.format(a,b,c))

#Ввод данных:
#a = input()
#print(a)

# print(' Введите первую строку ')
# a = input()
# print(a)

# print('Введите первое число: ')
# a = input()
# Или 
# b = input('Введите второе число: ')

#Вывод суммы чисел:
# print('Введите первое число: ')
# a = input() 
# b = input('Введите второе число: ')
# print(a,'+',b,'=',a+b)
# В ответе будет не сумма,а ab , так как получилось сложение строк a и b

# c = 4.76
# print(c)
# n = int(c)
# print(n)
# Так мы привели float с к целочисленному значению int   

#Вывод суммы чисел:
# print('Введите первое число: ')
# a = int(input()) 
# b = int(input('Введите второе число: '))
# print (a,'+',b,'=',a+b)

#Арифметические операции:

a = 5.8765
b = 6.7868
#print(a*b) Получается много знаков после запятой
#print(round(a*b, 2)) Используем функцию round и пишем,сколько чисел 
#после запятой - 2

#Сокращения:
# n = 2
# n += 3 это n = n + 3
# n -= 3 --- n = n - 3
# n *= 3 --- n = n * 3
# n /= 3 --- n = n / 3
# n //= 3 --- n = n // 3 Целочисленное деление
# n %= 3 --- n = n % 3 Остаток от деления
# n **= 3 --- n = n ** 3 Возведение в третью степень

# a = 'qwerty'
# for i in a:
#     print(i)

# line = ''
# for i in range(5):
#     line = ''
#     for j in range(5):
#         line += '*'
#     print(line)    

# text = 'СъЕШЬ ещё этих МяГкИх французских булок'
# #print(len(text))
# #print('ещё' in text)
# #print(text.lower())
# #print(text.upper())
# print(text.replace('ещё', 'ЕЩЁ'))

