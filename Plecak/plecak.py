rzeczy = []
try:
    with open("rzeczy.txt", "r", encoding="utf-8") as f:
        for linia in f:
            dane = linia.strip().split()
            if len(dane) == 3:
                nazwa = dane[0]
                waga = int(dane[1])
                wartosc = int(dane[2])
                rzeczy.append((nazwa, waga, wartosc))
except FileNotFoundError:
    print("Nie znaleziono pliku rzeczy.txt")
    exit(1)

if not rzeczy:
    print("Plik rzeczy.txt nie zawiera danych w formacie: nazwa waga wartość")
    exit(1)

try:
    max_waga = int(input("Podaj maksymalną wagę plecaka (w kg): "))
except ValueError:
    print("Musisz podać liczbę całkowitą!")
    exit(1)

n = len(rzeczy)
dp = [[0] * (max_waga + 1) for _ in range(n + 1)]

for i in range(1, n + 1):
    nazwa, waga, wartosc = rzeczy[i - 1]
    for w in range(1, max_waga + 1):
        if waga <= w:
            dp[i][w] = max(dp[i - 1][w], dp[i - 1][w - waga] + wartosc)
        else:
            dp[i][w] = dp[i - 1][w]

wybrane = []
w = max_waga
for i in range(n, 0, -1):
    if dp[i][w] != dp[i - 1][w]:
        nazwa, waga, wartosc = rzeczy[i - 1]
        wybrane.append((nazwa, waga, wartosc))
        w -= waga

print("\nNajlepsze rzeczy do spakowania:")
print("--------------------------------")
for r in reversed(wybrane):
    print(f"{r[0]:12} | waga: {r[1]} kg | wartość: {r[2]}")
print("--------------------------------")
print(f"Łączna wartość: {dp[n][max_waga]}")
print(f"Łączna waga: {sum(r[1] for r in wybrane)} / {max_waga} kg")
