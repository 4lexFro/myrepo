list = input("Введите слово: ")
def palindrome(x):
    if len(x) <= 1:
        return True
    elif x[0] == x[-1]:
        return palindrome(x[1: -1])
    return False
print (palindrome(list))
