def sort_and_insert(A, K):
    kill_first_K_alemes = A[K:]
    kill_first_K_alemes.sort(reverse = True)
    
    # A = list(set(kill_first_K_alemes))
    # new_collection = [x for x in A if x % 2 != 0]
    
    new_collection = [x for x in kill_first_K_alemes if x % 2 != 0]
    
    return new_collection

A = [10, 3, 5, 7, 2, 8, 4, 5, 2, 3, 4, 1, 1, 1, 11, 123, 6]
K = 4
result = sort_and_insert(A, K)
print(result)