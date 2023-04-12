# Задача 2: Найдите сумму цифр трехзначного числа.
# *Пример:*
# 123 -> 6 (1 + 2 + 3)
# 100 -> 1 (1 + 0 + 0) 

number = int(input(' Введите трехзначное число: '))
digit1 = number // 100
digit2 = (number % 100) // 10
digit3 = number % 10
sum = digit1 + digit2 + digit3
print(f' Сумма цифр числа {number} равна {sum}')
# num = str(number)
# if len (num) > 3 or len (num) < 3:
#     print(' Число не трехзначное')

# Альтернативное решение через строки:
# num = input(' Введите трехзначное число: ')
# print(f'{int(num[0])+int(num[1])+int(num[2])}')