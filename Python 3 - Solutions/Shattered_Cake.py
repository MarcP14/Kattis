#Shattered Cake
from sys import *
W = int(input())
input()

ploscina = 0
for vrstica in stdin:
    sez = list(map(int, vrstica.split(' ')))
    ploscina = ploscina + sez[0] * sez[1]
print(int(ploscina/W))
