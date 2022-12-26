i = input()
j = input()

rez = 1

for k in range(4):
    if i[k] != j[k]:
        rez = rez * 2

print(rez)