# Establece que una clase secundaria debe ser sustituible por su clase principal
# El principio de sustitución de Liskov tiene como objetivo garantizar que la
# _ clase secundaria pueda asumir el lugar de su clase principal sin causar ningún error

# importación de la herencia y un método abstracto
from abc import ABC, abstractmethod

class Contact:
    def __init__(self, name, email, phone):
        self.name = name
        self.email = email
        self.phone = phone
        pass

class Notification(ABC):
    @abstractmethod
    def notify(self, message, email):
        pass

class Email(Notification):
    def notify(self, message, email):
        print(f'send {message} to {email}')

class Text(Notification):
    def notify(self, _message_, phone):
        print(f'send {_message_} to {phone}')

class NotificationManager:
    def __init__(self, notification, contact):
        self.contact = contact
        self.notification = notification

    def send(self, message):
        if isinstance(self.notification, Email):
            self.notification.notify(message, contact.email)
        elif isinstance(self.notification, Text):
            self.notification.notify(message, contact.phone)
        else:
            raise Exception ('La notificación que nos enviaste no está disponible aún')

if __name__ == '__main__':
    # _notification = Email()
    # _notification.notify("hola", "anapissy75@gmail.com")

    contact = Contact("Ana Paola", "anapissy75@gmail.com", "55523464")
    not_manager = NotificationManager(Text(), contact)
    not_manager.send("Hola =>")
