class Line:
    def __init__(self, a, b, c):
        self.a = a
        self.b = b
        self.c = c

    def calc_k(self):
        return -(self.a / self.b)

    def calc_c(self):
        return -(self.c / self.b)

    '''def print(self):
        print('{0}x + {1}y + {2} = 0\n'.format(self.a, self.b, self.c))'''

    def print(self):
        return '{0}x + {1}y + {2} = 0\n'.format(self.a, self.b, self.c)
