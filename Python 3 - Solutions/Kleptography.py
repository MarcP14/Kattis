#Kleptography
abec = 'abcdefghijklmnopqrstuvwxyz'
input()
k = input()
b = input()

def decode(k, b):
    if len(b) <= len(k):
        return k[-len(b):]
    else:
        b1 = b[:-len(k)]
        b2 = b[-len(k):]
        temp = ''
        for i in range(len(b2)):
            temp = temp + abec[abec.index(b2[i]) - abec.index(k[i])]
        return  decode(temp, b1) + k
print(decode(k, b))
