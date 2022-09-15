# _ Establece que una clase secundaria debe ser sustituible por su clase principal.
# __ El principio de sustitución de Liskov tiene como objetivo garantizar que la
# ___ clase secundaria pueda asumir el lugar de su clase principal sin causar ningún error.

from abc import ABC, abstractmethod

class Person:
    def __init__(self, name):
        self.name = name


class PersonData(ABC):
    @abstractmethod
    def save(self, name):
        pass


class PersonDB(PersonData):
    def save(self, message,  name):
        print(f'{message} nombre: {name} en la DB')


class PersonJSON(PersonData):
    def save(self, message, name):
        print(f'{message} nombre: {name} como JSON')

class PersonXML(PersonData):
    def save(self, message, name):
        print(f'{message} nombre: {name} como XML')


class PersonStorage:
    def __init__(self, person, name):
        self.person = person
        self.name = name

    def store(self, data):
        if isinstance(self.person, PersonDB):
            self.person.save(data, person.name)
        elif isinstance(self.person, PersonJSON):
            self.person.save(data, person.name)
        elif isinstance(self.person, PersonXML):
            self.person.save(data, person.name)
        else:
            raise Exception(
                'La informacion que guardaste no esta disponible')


if __name__ == '__main__':
    person = Person("Carla Franco")
    PersonStorage(PersonDB(), person).store("Guardado => ")
    