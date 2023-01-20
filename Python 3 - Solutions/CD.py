data = input().rstrip().split(" ")

while data != ["0", "0"]:
    jack_CD_number = int(data[0])
    jill_CD_number = int(data[1])

    jack_CDs = []
    for i in range(jack_CD_number):
        jack_CDs.append(int(input()))
            
    jack_CDs_index = 0
    both_CD_number = 0
    for i in range(jill_CD_number):
        jill_CD = int(input())
        jack_CD = jack_CDs[jack_CDs_index]
        
        while jack_CD < jill_CD  and jack_CDs_index < jack_CD_number - 1:
            jack_CDs_index += 1
            jack_CD = jack_CDs[jack_CDs_index]
            
        if jack_CD < jill_CD:
            break
        if jack_CD == jill_CD:
            both_CD_number += 1
            if jack_CDs_index < jack_CD_number - 1:
                jack_CDs_index += 1
                jack_CD = jack_CDs[jack_CDs_index]

    while i<jill_CD_number-1:
        input()
        i +=1
        
    print(both_CD_number)
    data = input().rstrip().split(" ")
