import tkinter as tk
from tkinter import filedialog


def from_file():
    f = open(get_file_path())
    filetext = f.readlines()
    f.close()

    data = []
    for str in filetext:
        line = list(map(int, str.split()))
        data.append(line)

    return data


def get_file_path():
    try:
        root = tk.Tk()
        root.withdraw()

        file_path = filedialog.askopenfilename()

        return file_path

    except IOError:
        print('Проблематос с поиском файла\n')


def delete_null_rc(matrix):
    rows = len(matrix)
    cols = len(matrix[0])
    r = 0
    c = 0

    for r in range(rows - 1):
        if matrix[r][c] != 0:
            continue
        else:
            for c in range(cols):
                if matrix[r][c] != 0:
                    break
                if c == cols - 1:
                    matrix = delete(matrix, True, r)
                    matrix = delete_null_rc(matrix)
                    pass

    r = 0
    c = 0
    for c in range(cols - 1):
        if matrix[r][c] != 0:
            continue
        else:
            for r in range(rows):
                if matrix[r][c] != 0:
                    break
                if r == rows - 1:
                    matrix = delete(matrix, False, c)
                    matrix = delete_null_rc(matrix)
                    pass
    return matrix


def find_null_line(matrix, rows, cols):
    r = 0
    c = 0

    for r in range(rows - 1):
        if matrix[r][c] != 0:
            continue
        else:
            for c in range(cols):
                if matrix[r][c] != 0:
                    break
                if c == cols - 1:
                    matrix = delete(matrix, True, r)
                    matrix = delete_null_rc(matrix)
                    pass



#если передано true, то удаляю строку, если false, то столбец
def delete(matrix, what, ind):
    if what:
        del matrix[ind]
    else:
        for elem in matrix:
            del elem[ind]

    return matrix


matrix = from_file()
matrix = delete_null_rc(matrix)
print(matrix)
