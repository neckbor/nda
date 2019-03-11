import Line
import tkinter as tk
from tkinter import filedialog


def read_lines(way):
    lines = []
    if way:
        lines = from_file()
    else:
        lines = from_console()

    return lines


def from_console():
    lines = []

    print('\nНажмите enter, чтобы добавить прямую.\n'
          'Введите exit в поле command, когда добвите все прямые')

    command = input('command= ')
    while command != 'exit':
        a = int(input('a= '))
        b = int(input('b= '))
        c = int(input('c= '))

        line = Line.Line(a, b, c)
        lines.append(line)

        command = input('command= ')

    filter_lines(lines)
    for line in lines:
        line.print()

    return lines


def from_file():
    path = get_file_path()
    f = open(path)
    filetext = f.readlines()
    f.close()

    lines = []
    for str in filetext:
        line = list(map(int, str.split()))
        lines.append(Line.Line(line[0], line[1], line[2]))

    filter_lines(lines)

    f = open(path, 'w')
    for line in lines:
        f.write(line.print())
    f.close()

    return lines


def get_file_path():
    try:
        root = tk.Tk()
        root.withdraw()

        file_path = filedialog.askopenfilename()

        return file_path

    except IOError:
        print('Проблематос с поиском файла\n')


def filter_lines(lines):
    i = 0
    lines.sort(key=sort_by_k, reverse=True)
    while i < len(lines):
        while i+1 < len(lines) and lines[i].calc_k() == lines[i+1].calc_k() and lines[i].calc_c() >= lines[i+1].calc_c():
            del lines[i+1]
        i += 1


def sort_by_k(line):
    return line.calc_k()


def print_lines(lines):
    for elem in lines:
        print(elem.print())


lines = read_lines(input('Выберите способ задания уравнений прямых. Если вручную, то нажмите enter\n'
                         'если из файла, то любой символ и enter'))
