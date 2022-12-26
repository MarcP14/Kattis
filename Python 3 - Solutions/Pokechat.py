sez = list(input())
cod =  input()

rez = ""
i = 0
while i < len(cod):
    rez = rez + sez[int(cod[i:i+3])-1]
    i = i + 3


print(rez)


