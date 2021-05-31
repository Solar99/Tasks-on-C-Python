print('Введите числа через пробел.')
a = [int(j) for j in input().split()]
for j in range(len(a)):
    if a[j]%3 == 0:
     print(a[j])
         

