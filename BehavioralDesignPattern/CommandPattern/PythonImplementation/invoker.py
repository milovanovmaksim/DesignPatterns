from command import Command


class Invoker:
    """
    Отправитель связан с одной или несколькими командами. Он отправляет запрос
    команде.
    """
    
    _on_start = None
    _on_finish = None
    
    """
    Инициализация команд
    """
    
    def set_on_start(self, command: Command):
        self._on_start = command
        
    def set_on_finish(self, command: Command):
        self._on_finish = command
        
    def do_something_important(self):
        """
        Отправитель не зависит от классов конкретных команд и получателей.
        Отправитель передает запрос получателю косвенно, выполняя команду.
        """
        
        print("Invoker: Does anybody want something done before i begin?")
        if isinstance(self._on_start, Command):
            self._on_start.execute()
        
        print("Invoker: ...doing something really important...")
        
        print("Invoker: Does anybody want something done after I finish?")
        if isinstance(self._on_finish, Command):
            self._on_finish.execute()
