print("TO JEST DOCKER - skibidi")
#-----------------------------------
class Urzadzenia:
    def komunikat(self,tresc: str)->None:
        print(tresc)

class Pralka(Urzadzenia):
    def __init__(self):
        self.__numer_programu: int = 0

    def ustaw_program(self, numer)->int:
        if isinstance(numer,int) and 1 <= numer <= 12:
            self.__numer_programu = numer
            print(f"Podaj numer prania: {self.__numer_programu}")
        else:
            self.__numer_programu = 0
            print(f"Podano nieprawidłowy numer programu: {self.__numer_programu}")
            return self.__numer_programu


class Odkurzacz(Urzadzenia):
    def __init__(self):
        self.__stan: bool = True

    def on(self)->None:
        if not self.__stan:
            self.__stan = True
            self.komunikat("Odkurzacz włączony")

    def off(self)->None:
        if not self.__stan:
            self.__stan = False
            self.komunikat("Odkurzacz wyłączony")

def main():
    pralka = Pralka()
    odkuracz = Odkurzacz()

    print("Podaj numer prania 1..12")
    wejscie = input("Wpisz nr programu prania: ").strip()

try: 
    numer = int(wejscie)
except ValueError:
    numer = wejscie

wynik = pralka.ustaw_program(numer)
print(f"Zwrocony numer programu: {wynik}\n")
odkurzacz.on()
odkurzacz.on()
odkurzacz.on()

odkurzacz