#Transit Woes
import math
cilj = list(map(int, input().split(' ')))
cas_hoje = list(map(int, input().split(' ')))
cas_voznje = list(map(int, input().split(' ')))
cas_odhoda = list(map(int, input().split(' ')))

zacetek = cilj[0] + cas_hoje[0]
cas_hoje = cas_hoje[1:]
for i in range(0, cilj[2]):
    zacetek = math.ceil(zacetek/cas_odhoda[i])*cas_odhoda[i]
    zacetek = zacetek + cas_voznje[i]+ cas_hoje[i]

if(zacetek > cilj[1]):
    print('no')
else:
    print('yes')
