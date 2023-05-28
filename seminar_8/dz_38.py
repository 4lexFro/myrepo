# Задача 38: 
# Дополнить телефонный справочник возможностью изменения и удаления данных. 
# Пользователь также может ввести имя или фамилию, и Вы должны реализовать функционал для 
# изменения и удаления данных

def show_menu():
    print("\nВыберите нужное действие: \n"
          "1.Отобразить весь справочник\n"
          "2.Найти абонента по фамилии\n"
          "3.Найти абонента по номеру\n"
          "4.Добавить абонента\n"
          "5.Удалить абонента\n"
          "6.Сохранить справочник в текстовом формате\n"
          "7.Закончить работу\n")
    choice = int(input())
    return choice

def read_csv(filename:str):
    data = []
    fields = ["Фамилия", "Имя", "Телефон", "Описание"]
    with open(filename, 'r', encoding='utf-8') as fin:
        for line in fin:
            record = dict(zip(fields, line.strip().split(',')))
            data.append(record)
    return data

def write_txt(filename:str, data:list):
    with open(filename, 'w', encoding='utf-8') as f_out:
        for i in range(len(data)):
            s = ''
            for value in data[i].values():
                s += value + ','
            f_out.write(f'{s[:-1]}\n')

def print_result(data:list):
    print('-'*10)
    for elem in data:
        for key in elem:
            print(f"{key} : {elem[key]}")
        print('-'*10)

def get_search_name():
    return input('Фамилия: ')

def find_by_name(data:list, name: str):
    result = []
    for elem in data:
        if elem['Фамилия'] == name:
            result.append(elem)
    return result

def find_by_number(data:list, number: str):
    result = []
    for elem in data:
        if elem['Телефон'] == number:
            result.append(elem)
    return result

def get_new_user():
    fields = ["Фамилия", "Имя", "Телефон", "Описание"]
    record = dict(zip(fields, input('Введите фамилию, имя, номер, описание').strip().split(',')))
    return record
    
def add_user(data:list, user:dict):
    return data.append(user)

def write_csv(filename:str, data:list):
    with open(filename, 'w', encoding='utf-8') as f_out:
        for i in range(len(data)):
            s = ''
            for value in data[i].values():
                s += value + ','
            f_out.write(f'{s[:-1]}\n')

def delete_by_name(data:list, name: str):
    for elem in data:
        if elem['Фамилия'] == name:
            data.remove(elem)
    return data




def work_with_phonebook():
    choice = show_menu()
    phone_book = read_csv('seminar_8\phonebook.csv')

    while(choice!=7):
        if choice == 1:
            print_result(phone_book)
        elif choice == 2:
            name = get_search_name()
            print_result(find_by_name(phone_book, name))
        elif choice == 3:
            num = input("номер: ")
            print_result(find_by_number(phone_book, num))
        elif choice == 4:
            new_user = get_new_user()
            add_user(phone_book, new_user)
            write_csv('seminar_8\phonebook.csv', phone_book)
        elif choice == 5:
            del_name = get_search_name()
            delete_by_name(phone_book, del_name)
            write_csv('seminar_8\phonebook.csv', phone_book)
        elif choice == 6:
            write_txt('phonebook.txt', phone_book)
        choice = show_menu()

work_with_phonebook()