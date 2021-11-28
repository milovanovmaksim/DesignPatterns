class Receiver:
    """
    Классы Получателей содержат некую важную бизнес-логику. Они умеют выполнять
    все виды операций, связанных с выполнением запроса. Фактически, любой класс
    может выступать Получателем.
    """
    
    def do_something(self, a):
        print(f"\nReceiver: Working on ({a}.)", end="")
    
    def do_something_else(self, b):
        print(f"\nReceiver: Also working on ({b}.)\n", end="")
