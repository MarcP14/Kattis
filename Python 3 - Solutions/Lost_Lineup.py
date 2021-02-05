#Lost Lineup
input()
orig_sez = input().split(' ')
sorted_sez = sorted(orig_sez)
if not orig_sez ==['']:
    orig_sez = list(map(int,orig_sez))
    sorted_sez = sorted(orig_sez)
    print('1 ' + ' '.join(list(map(lambda x:str(orig_sez.index(x)+2), sorted_sez))))
else:
    print('1') 

