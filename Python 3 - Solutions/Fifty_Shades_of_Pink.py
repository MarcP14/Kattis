#Fifty Shades of Pink
from sys import *
input()

stej= 0
for vrstica in stdin:
    if "pink" in vrstica.lower() or "rose" in vrstica.lower():
        stej+=1
        
if stej == 0:
    print("I must watch Star Wars with my daughter")
else:
    print(stej)
