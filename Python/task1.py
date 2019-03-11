import tkinter as tk
from tkinter import filedialog


def make_one_exclusive_list(list1, list2):
    result = []
    for elem in list1:
        if elem not in list2 and elem not in result:
            result.append(elem)

    for elem in list2:
        if elem not in list1 and elem not in result:
            result.append(elem)

    if len(result) == 0:
        print('В списках нет индивидуальных чисел\n\n')
        return None
    else:
        return result


def getfilepath():
    try:
        root = tk.Tk()
        root.withdraw()

        file_path = filedialog.askopenfilename()

        return file_path

    except IOError:
        print('Проблематос с поиском файла\n')


def filedata():
    try:
        f = open(getfilepath())
        list1 = list(map(int, f.readline().split()))
        f.close()

        f = open(getfilepath())
        list2 = list(map(int, f.readline().split()))
        f.close()

        return make_one_exclusive_list(list1, list2)

    except ValueError:
        print('В файле недопустимые значения\n')


def consoledata():
    try:
        list1 = list(map(int, input('list1 ').split()))
        list2 = list(map(int, input('list2 ').split()))

        return make_one_exclusive_list(list1, list2)
    except ValueError:
        print('Недопустимое значение\n')


while True:
    try:
        result = []
        command = int(input('Если данные брать из файла, то введите 1, если вручную, то введите 2, 0 - выход: '))
        if command == 1:
            result = filedata()
        elif command == 2:
            result = consoledata()
        elif command == 0:
            break
        else:
            raise ValueError

    except ValueError:
        print('Команда не распознана\n')

    print(result, sep=' ')
