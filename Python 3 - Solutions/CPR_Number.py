niz = input()
niz = niz[:6]+niz[7:]
niz = list(niz)

const = [4,3,2,7,6,5,4,3,2,1]
sum = 0
for i in range(len(niz)):
    sum += int(niz[i]) * const[i]

if(sum%11 == 0):
    print("1") 
else:
    print("0")