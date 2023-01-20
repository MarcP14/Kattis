de_que1 = []
de_que2 = []

l1 = 0
l2 = 0

cases = int(input())

for c in range(cases):
    command = input().rstrip().split(" ")
    
    action = command[0]
    element = command[1]

    if action == "push_back":
        de_que2.append(element)
        l2 +=1
        if l1 < l2:
            de_que1.append(de_que2[0])
            de_que2 = de_que2[1:]
            l1 +=1
            l2 -=1
    elif action == "push_front":
        de_que1 = [element]+ de_que1
        l1 +=1
        if l1 - 1 > l2:
            x = de_que1.pop()
            de_que2 = [x]+ de_que2
            l2 +=1
            l1 -=1
    elif action == "push_middle":
        if l1 <= l2:
            de_que1.append(element)
            l1 +=1
        else:
            de_que2 = [element]+ de_que2
            l2 +=1
    else:
        index = int(element)
        if index < l1: 
            print(de_que1[index])
        else:
            print(de_que2[index - l1])
    print(de_que1, l1)
    print(de_que2, l2)
