##T9 Spelling
import sys

input()

mobitel = {'a': '2', 'p': '7', 's': '7777', 'z': '9999', 'e': '33', ' ': '0', 'y': '999', 'u': '88', 'f': '333', 'b': '22', 'i': '444', 'o': '666', 'l': '555', 'r': '777', 'c': '222', 'j': '5', 'h': '44', 'x': '99', 't': '8', 'd': '3', 'w': '9', 'n': '66', 'v': '888', 'g': '4', 'k': '55', 'q': '77', 'm': '6'}
primer = 1

for vrstica in sys.stdin:
    vrstica = vrstica.rstrip('\n')
    pritiski = ''
    for crka in vrstica:
        if len(pritiski) != 0 and mobitel[crka][0] == pritiski[-1]:
            pritiski += ' '
        pritiski += mobitel[crka]
    print('Case #'+str(primer)+': '+pritiski)
    primer+=1
