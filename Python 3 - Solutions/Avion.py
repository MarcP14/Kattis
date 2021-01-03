#Avion
from sys import *

indeks_vrstice = 1
katere_FBI = []
for vrstica in stdin:
    if "FBI" in vrstica:
        katere_FBI.append(str(indeks_vrstice))
    indeks_vrstice+=1
    
if katere_FBI == []:
    print("HE GOT AWAY!")
else:
    print(" ".join(katere_FBI))
