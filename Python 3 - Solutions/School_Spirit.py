#School Spirit
koliko = int(input())

skupaj = 0
parcialno = 0
for i in range(koliko):
    trenutno = int(input())
    skupaj = skupaj + trenutno * (4/5)**i
    parcialno = parcialno + trenutno*((koliko - 1 - i)*(4/5)**i + (i)*(4/5)**(i-1))
print(skupaj/5, parcialno/(5*koliko))

