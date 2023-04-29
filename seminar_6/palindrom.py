list = input("Введите слово: ")
def palindrome(x):
    if len(x) <= 1: # если длина слова равна единице - нашли середину слова
        return True
    elif x[0] == x[-1]: # если первый элемент равен последнему
        return palindrome(x[1: -1]) # рекурсия с аргументами второго и предпоследнего элементов
    return False
print (palindrome(list))
