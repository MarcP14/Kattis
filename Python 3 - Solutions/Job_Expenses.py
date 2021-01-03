#Job Expenses
if input() != "0":
    seznam_negativnih = sorted(list(map(int, input().split(' '))) + [0])
    indeks_od_nic = seznam_negativnih.index(0);
    print(sum(seznam_negativnih[:indeks_od_nic])*(-1))
else:
    print(0)
