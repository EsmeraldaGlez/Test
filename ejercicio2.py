lst = []
numeros = ['0','1','2','3','4','5','6','7','8','9']
cadena = input('Introduce una cadena de caracteres: ')

cantidad = 0
for i in cadena:
    lst.append(i)

for x in lst:
    for i in numeros:
        if x == i:
            cantidad+=1
print('Introdujo ',cantidad,' numeros')
     