# На вход поступает строка. На Python отсортировать строку в массив с элементов.

def str_to_arr1(string):
    return list(string)

a = str(input())
result1 = str_to_arr1(a)
print(result1)

# На вход поступает строка. На Python отсортировать строку в новую строку с соседними элементами. Если длина исходной строки нечётная, то добавить в последнюю пару "_"

def str_to_arr2(string):
    if len(string) % 2 != 0:
        string += '_'
        
    neighbor_array = []
    
    for i in range(len(string) - 1):
        neighbor_array.append(string[i] + string[i + 1])
    
    return neighbor_array

b = str(input())
result2 = str_to_arr2(b)
print(result2)