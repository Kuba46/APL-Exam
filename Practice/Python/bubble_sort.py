def bubble_sort(arr):
    n = len(arr)
    
    for i in range(n):
        for j in range(0, n - i - 1):
            if (arr[j] > arr[j + 1]):
                arr[j], arr[j + 1] = arr[j + 1], arr[j]
    return arr

input = [1.2, 5.34, 3.2, 1, 23.2, 11.45, -5.2, -3, -3.2, -5.1]
result = bubble_sort(input)
print(result)
