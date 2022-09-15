# _ El principio nos indica que una clase debe de implementar únicamente
# __ las interfaces que necesita, es decir, que no necesite tener que implementar
# ___ métodos que no utilice.
# _ El propósito de este principio es obligarnos a escribir interfaces pequeñas
# __  buscando aplicar el principio de cohesión en cada interfaz.

from abc import ABC, abstractmethod

class Movable(ABC):
    @abstractmethod
    def go(self, matricula):
        pass

class Flyable(Movable):
    @abstractmethod
    def fly(self, matricula):
        pass

class Aircraft(Flyable):
    def go(self, matricula):
        print(f"Taxiing {matricula}")
    def fly(self, matricula):
        print(f"Flying {matricula}")

class Car(Movable):
    def go(self, matricula):
        print(f"Driving {matricula}")

if __name__ == '__main__':
    Aircraft().fly("A637AA")
    Car().go("A637BB")