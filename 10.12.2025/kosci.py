import random

def throw(num_dices: int)->list[int]:
    """
    *****************************************************
    nazwa: throw
    opis: symuluje rzut zadania liczba kosci i zwraca wynik jako liste
    parametry: num_dices - liczba kosci którymi należy rzucić 
    zwracany typ i opis: list[int] - zwraca wartosci rzuconych kości
    autor: jezyk
    *****************************************************
    """

    return [random.randint(1,6) for _ in range(num_dices)]
def calculate_score(dices: list[int])->int:
    counts = [0,0,0,0,0,0]
    for dice in dices:
        counts[dice -1] += 1
    sum = 0

    for i in range(6):
        if counts[i] > 1:
            sum += counts[i] * (i+1)
    return sum

def main():
    num_dices = 0
    while not (3<num_dices<=10):
        num_dices = int(input("Ile kostek chcesz rzucić (3-10)?"))
    
    while True:
        dices = throw(num_dices)

        for i in range(num_dices):
            print(f"Kostka {i+1}: {dices[i]}")
        print(f"Liczba uzywkanych punktów: {calculate_score(dices)}")

        again = input("Jeszcze raz? (t/n)")
        if again not in ['t','T']:
            break
        
if __name__ == '__main__':
    main()