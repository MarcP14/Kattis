###Honour Thy (Apaxian) Parent
seznam = input().split(' ')
konec_besede = seznam[0][-2:]
if konec_besede == 'ex':
    print(''.join(seznam))
else:
    konec_besede = konec_besede[-1]
    if konec_besede == 'e':
        print('x'.join(seznam))
    elif konec_besede in 'aiou':
        print('ex'.join([seznam[0][:-1], seznam[1]]))
    else:
        print('ex'.join(seznam))
        
