def str_to_arr1(string):
    return list(string)

a = str(input())
result1 = str_to_arr1(a)
print(result1)

def str_to_arr2(string):
    neighbor_array = []
    
    for i in range(len(string) - 1):
        neighbor_array.append(string[i] + string[i + 1])
    
    return neighbor_array

b = str(input())
result2 = str_to_arr2(b)
print(result2)