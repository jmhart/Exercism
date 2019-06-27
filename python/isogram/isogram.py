def is_isogram(string):
    letters = sorted("".join(c.lower() for c in string if c.isalpha()))

    for i in range(len(letters) - 1):
        if letters[i] == letters[i + 1]:
            return False

    return True
