##Line Them Up
import sys

input()

sez = []

for vrstica in sys.stdin:
    sez.append(vrstica.rstrip('\n'))
    
if sez == sorted(sez):
    print('INCREASING')
elif sez == sorted(sez, reverse=True):
    print('DECREASING')
else:
    print('NEITHER')
