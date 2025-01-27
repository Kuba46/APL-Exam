def Fibonacci(n):
    if n < 0:
        raise ValueError("У последовательности Фибоначчи нет отрицательного порядка")
    elif n == 0:
        return 0
    elif n == 1:
        return 1
    else:
        return Fibonacci(n - 1) + Fibonacci(n - 2)
    
try:
    print("Введите n член последовательности: ")
    a = int(input())
    result = Fibonacci(a)
    print(f"F({a}) = {result}")
except ValueError as e:
    print(e)
except Exception as e:
    print("Произошла ошибка:", e)