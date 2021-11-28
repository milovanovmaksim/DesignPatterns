from invoker import Invoker
from receiver import Receiver
from command import ComplexCommand, SimpleCommand


invoker = Invoker()
invoker.set_on_start(SimpleCommand("Say Hi!"))
receiver = Receiver()
invoker.set_on_finish(ComplexCommand(receiver, 'Send email', 'Save report'))

invoker.do_something_important()