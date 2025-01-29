import readchar

# Написать на python программу, которая считает количество вхождений символа в строку

def count_desired_chars(string, char):
    count = 0
    for c in string:
        if c == char:
            count += 1
    return count

input_string = str(input())
print()
desired_char = readchar.readchar()
result = count_desired_chars(input_string, desired_char)
print(f"Character '{desired_char}' enters the string '{result}' times")