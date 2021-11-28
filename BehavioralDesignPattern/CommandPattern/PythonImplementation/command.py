from abc import ABC, abstractmethod

from receiver import Receiver


class Command(ABC):
    """
    Интерфейс Команды объявляет метод для выполнения команд.
    """

    @abstractmethod
    def execute(self):
        pass
   

class SimpleCommand(Command):
    """
    Некоторые команды способны выполнять простые операции самостоятельно.
    """
    
    def __init__(self, payload):
        self._payload = payload
        
    def execute(self):
        print(f"SimpleCommand: See, I can do simple things like printing {self._payload}")


class ComplexCommand(Command):
    """
    Но есть и команды, которые делегируют более сложные операции другим
    объектам, называемым «получателями».
    """
    
    def __init__(self, receiver: Receiver, a, b):
        """
        Сложные команды могут принимать один или несколько объектов-получателей
        вместе с любыми данными о контексте через конструктор.
        """
        
        self._receiver = receiver
        self._a = a
        self._b = b
        
    def execute(self):
        """
        Команды могут делегировать выполнение любым методам получателя.
        """
        print("ComplexCommand: Complex stuff should be done by a receiver object", end="")
        self._receiver.do_something(self._a)
        self._receiver.do_something_else(self._b)
