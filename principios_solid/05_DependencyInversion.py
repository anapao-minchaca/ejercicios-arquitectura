# _ En este principio se establecen que las dependencias deben de estar en las
# __ abstracciones y no en las concreciones, en otras palabras, nos piden que las
# ___ clases nunca dependan de otras clases y que toda esta relación debe estar en
# ____ una abstracción. Este principio tiene dos reglas:

# _ 1.-Los módulos de alto nivel no deben depender de módulos de bajo nivel.
# __ Esta lógica debe de estar en una abstracción.
# _ 2.-Las abstracciones no deben depender de detalles. Los detalles deberían depender
# __ de abstracciones.

from abc import ABC

class CurrencyConverter(ABC):
    def convert(self, from_currency, to_currency, amount) -> float:
        pass

class FXConverter(CurrencyConverter):
    def convert(self, from_currency, to_currency, amount) -> float:
        print('Converting currency using FX API')
        print(f'{amount} {from_currency} = {amount * 1.201} {to_currency}')
        return amount * 1.15

class AlphaConverter(CurrencyConverter):
    def convert(self, from_currency, to_currency, amount) -> float:
        print('Converting currency using Alpha API')
        print(f'{amount} {from_currency} = {amount * 1.2} {to_currency}')
        return amount * 1.2

class App:
    def __init__(self, converter: CurrencyConverter):
        self.converter = converter

    def start(self, from_currency, to_currency, amount):
        self.converter.convert(from_currency, to_currency, amount)

if __name__ == '__main__':
    App(FXConverter()).start('EUR', 'USD', 100)
    App(AlphaConverter()).start('EUR', 'USD', 200)