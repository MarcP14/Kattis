string = input().rstrip()

string_list = list(string)
string_set = set(string_list)

if len(string_set)<=2:
    print("0")
else:
    eliminacija_dist = len(string_set)-2

    string_dict = dict()
    for crka in string:
        if crka not in string_dict.keys():
            string_dict[crka] = 1
        else:
            string_dict[crka] += 1
            
    st_ponovitev = 1
    st_odtsrnjenih = 0
    while eliminacija_dist > 0:
        odstrani = []
        for crka in string_dict.keys():
            if eliminacija_dist == 0:
                break
            if string_dict[crka] == st_ponovitev:
                odstrani.append(crka)
                st_odtsrnjenih += st_ponovitev
                eliminacija_dist -= 1

        for crka in odstrani:
            string_dict.pop(crka)
        st_ponovitev += 1

    print(st_odtsrnjenih)
