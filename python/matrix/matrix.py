class Matrix(object):
    def __init__(self, matrix_string):
        self.matrix = [list(map(int, i.split(" ")))
                       for i in matrix_string.split("\n")]

    def row(self, index):
        if index <= 0:
            raise IndexError("Index must be greater than 0")
        return self.matrix[index - 1]

    def column(self, index):
        if index <= 0:
            raise IndexError("Index must be greater than 0")
        return [i[index - 1] for i in self.matrix]
