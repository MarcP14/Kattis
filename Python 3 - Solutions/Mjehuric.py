##Mjehuric
seznam = input().split(' ')

while seznam != ['1', '2', '3', '4', '5']:
    for i in range(4):
        if seznam[i] > seznam[i+1]:
            temp =  seznam[i]
            seznam[i] = seznam[i+1]
            seznam[i+1] = temp
            print(' '.join(seznam))
