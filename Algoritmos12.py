def Multiplicacion():    
    numero1=0
    numero2=0

    while numero1<30 or numero1>99:
        numero1=int(input('1er Num: '))
    while numero2<30 or numero2>99:
        numero2=int(input('2do Num: '))
    print(numero1*numero2)
Multiplicacion()