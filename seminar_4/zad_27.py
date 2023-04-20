# Задача №27. Решение в группах

# Пользователь вводит текст(строка). Словом считается
# последовательность непробельных символов идущих
# подряд, слова разделены одним или большим числом
# пробелов. Определите, сколько различных слов
# содержится в этом тексте.

# Input: She sells sea shells on the sea shore The shells
# that she sells are sea shells I'm sure.So if she sells sea
# shells on the sea shore I'm sure that the shells are sea
# shore shells

# Output: 13
x = "She sells sea shells on the sea shore The shells that she sells are sea shells I'm sure.So if she sells sea shells on the sea shore I'm sure that the shells are sea shore shells"
y = x.lower().replace('.', ' ').split(" ") # lower - приводим текст в нижний регистр
# replace - заменяем точку пробелом
# split - создает из строки список  
print(y)
newSecondList = []
for i in y:
    if i not in newSecondList:
        newSecondList.append(i)
print(newSecondList)
print(len(newSecondList))  