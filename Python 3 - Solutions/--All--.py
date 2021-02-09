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

####Mjehuric
##seznam = input().split(' ')
##
##while seznam != ['1', '2', '3', '4', '5']:
##    for i in range(4):
##        if seznam[i] > seznam[i+1]:
##            temp =  seznam[i]
##            seznam[i] = seznam[i+1]
##            seznam[i+1] = temp
##            print(' '.join(seznam))

####T9 Spelling
##import sys
##
##input()
##
##mobitel = {'a': '2', 'p': '7', 's': '7777', 'z': '9999', 'e': '33', ' ': '0', 'y': '999', 'u': '88', 'f': '333', 'b': '22', 'i': '444', 'o': '666', 'l': '555', 'r': '777', 'c': '222', 'j': '5', 'h': '44', 'x': '99', 't': '8', 'd': '3', 'w': '9', 'n': '66', 'v': '888', 'g': '4', 'k': '55', 'q': '77', 'm': '6'}
##primer = 1
##
##for vrstica in sys.stdin:
##    vrstica = vrstica.rstrip('\n')
##    pritiski = ''
##    for crka in vrstica:
##        if len(pritiski) != 0 and mobitel[crka][0] == pritiski[-1]:
##            pritiski += ' '
##        pritiski += mobitel[crka]
##    print('Case #'+str(primer)+': '+pritiski)
##    primer+=1


###Kleptography
##abec = 'abcdefghijklmnopqrstuvwxyz'
##input()
##k = input()
##b = input()
##
##def decode(k, b):
##    if len(b) <= len(k):
##        return k[-len(b):]
##    else:
##        b1 = b[:-len(k)]
##        b2 = b[-len(k):]
##        temp = ''
##        for i in range(len(b2)):
##            temp = temp + abec[abec.index(b2[i]) - abec.index(k[i])]
##        return  decode(temp, b1) + k
##print(decode(k, b))
    

###Lost Lineup
##input()
##orig_sez = input().split(' ')
##sorted_sez = sorted(orig_sez)
##if not orig_sez ==['']:
##    orig_sez = list(map(int,orig_sez))
##    sorted_sez = sorted(orig_sez)
##    print('1 ' + ' '.join(list(map(lambda x:str(orig_sez.index(x)+2), sorted_sez))))
##else:
##    print('1') 


###School Spirit
##koliko = int(input())
##
##skupaj = 0
##parcialno = 0
##for i in range(koliko):
##    trenutno = int(input())
##    skupaj = skupaj + trenutno * (4/5)**i
##    parcialno = parcialno + trenutno*((koliko - 1 - i)*(4/5)**i + (i)*(4/5)**(i-1))
##print(skupaj/5, parcialno/(5*koliko))

###Fifty Shades of Pink
##from sys import *
##input()
##
##stej= 0
##for vrstica in stdin:
##    if "pink" in vrstica.lower() or "rose" in vrstica.lower():
##        stej+=1
##        
##if stej == 0:
##    print("I must watch Star Wars with my daughter")
##else:
##    print(stej)


#####Honour Thy (Apaxian) Parent
##seznam = input().split(' ')
##konec_besede = seznam[0][-2:]
##if konec_besede == 'ex':
##    print(''.join(seznam))
##else:
##    konec_besede = konec_besede[-1]
##    if konec_besede == 'e':
##        print('x'.join(seznam))
##    elif konec_besede in 'aiou':
##        print('ex'.join([seznam[0][:-1], seznam[1]]))
##    else:
##        print('ex'.join(seznam))
##        
    
###Tetration
##N = float(input())
##print(round(N**(1/N),6))


###Avion
##from sys import *
##
##indeks_vrstice = 1
##katere_FBI = []
##for vrstica in stdin:
##    if "FBI" in vrstica:
##        katere_FBI.append(str(indeks_vrstice))
##    indeks_vrstice+=1
##    
##if katere_FBI == []:
##    print("HE GOT AWAY!")
##else:
##    print(" ".join(katere_FBI))

###Job Expenses
##if input() != "0":
##    seznam_negativnih = sorted(list(map(int, input().split(' '))) + [0])
##    indeks_od_nic = seznam_negativnih.index(0);
##    print(sum(seznam_negativnih[:indeks_od_nic])*(-1))
##else:
##    print(0)


###Shattered Cake
##from sys import *
##W = int(input())
##input()
##
##ploscina = 0
##for vrstica in stdin:
##    sez = list(map(int, vrstica.split(' ')))
##    ploscina = ploscina + sez[0] * sez[1]
##print(int(ploscina/W))

        
###Transit Woes
##import math
##cilj = list(map(int, input().split(' ')))
##cas_hoje = list(map(int, input().split(' ')))
##cas_voznje = list(map(int, input().split(' ')))
##cas_odhoda = list(map(int, input().split(' ')))
##
##zacetek = cilj[0] + cas_hoje[0]
##cas_hoje = cas_hoje[1:]
##for i in range(0, cilj[2]):
##    zacetek = math.ceil(zacetek/cas_odhoda[i])*cas_odhoda[i]
##    zacetek = zacetek + cas_voznje[i]+ cas_hoje[i]
##
##if(zacetek > cilj[1]):
##    print('no')
##else:
##    print('yes')
