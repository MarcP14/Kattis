import math

cases = int(input())

def radius(n, m):
    krog = 1
    r = 0
    q = 1
    while krog<=m:
        sin_alpha = math.sin(alpha)
        if krog == 1:
            r =sin_alpha/(1-sin_alpha)
        else:
            if krog == 2:
                q = 1 + 2*r
            else:
                q = r/sin_alpha + r
            tan_alpha = math.tan(alpha)
            r_tan_alpha = tan_alpha*r
            D = r*r + r_tan_alpha*(-2*r + r_tan_alpha + 2*q)
            x = r_tan_alpha-r+math.sqrt(D)
            r = tan_alpha*q+tan_alpha*x
        krog +=1
    return r

def circumference(n, r):
    return 2*r*n + 2*r*math.pi

for i in range(1,cases+1):
    data = input().rstrip().split(" ")

    N = int(data[1])
    M = int(data[2])

    alpha = math.pi/N

    R = radius(N,M)
    C = round(circumference(N, R), 3)
    R = round(R,3)

    print(i, R, C)
