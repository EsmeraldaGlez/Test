while True:
    try:
        dia, mes,anio = [int(x) for x in input('introduce una fecha con el formato dd/mm/yyyy: ').split('/')]
        break
    except ValueError:
        print('Formato incorrecto')
    

if mes in [1, 3, 5, 7, 8 , 10, 12]:
    if dia <= 31:
        print("Fecha valida :) ")
    else :
        print("La fecha no es valida :c ")

if mes in [4, 6, 9, 11]:
    if dia <= 30 :
        print("Fecha valida :) ")
    else:
        print("Fecha invalida ")
        
if mes > 12:
    print("Fecha invalida")

residuo = anio % 4

if mes == 2:
    if residuo == 1:
        if dia <= 28:
            print("Fecha valida :) ")
        else:
            print("Fecha invalida")
    elif residuo == 0:
        if dia <= 29 :
            print("Fecha valida :)")
        else:
            print("Fecha invalida")
