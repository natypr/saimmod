from collections import Counter

from Handler import Handler
from Lemer import LemerGenerator
from Source import Source
from TaskQueue import TaskQueue


class Mediator:

    def __init__(self, p1=0.4, p2=0.5, iteration_count=100000):

        self.iteration_count = iteration_count
        self.task_in_system_count = 0
        self.current_tick = 0
        self.handled_count = 0
        self.refused_count = 0
        self.states = []
        self.p1 = p1
        self.source = Source()
        self.queue = TaskQueue(2)
        self.handlers = [Handler(p1, LemerGenerator(209715120, 3, 7)), Handler(p2, LemerGenerator(209715120, 3, 7))]

    def run(self):

        self.queue.tick()

        for i in range(self.iteration_count):
            self.tick()

        counter = Counter(self.states)

        for key in counter.keys():
            counter[key] = counter[key] / self.iteration_count
            print('P{0} = {1}'.format(key, counter[key]))

        Loch = self.queue.sum_of_sizes / self.iteration_count
        Lc = self.task_in_system_count / self.iteration_count
        A = self.handled_count / self.iteration_count
        Кkan2 = self.handlers[1].total_task_count / self.iteration_count

        print()
        print('Potk = {0}'.format(self.refused_count / self.source.total_task_count))
        print('Pбл = 0')
        print('Loch = {0}'.format(Loch))
        print('Lc = {0}'.format(Lc))
        print('Q = {0}'.format(self.handled_count/self.source.total_task_count))
        print('A = {0}'.format(A))
        print('Woch = {0}'.format(Loch/A))
       # print('Wc = {0}'.format(Lc/A))
        print('Wc = {0}'.format(1/(1-self.p1) + (Loch + Кkan2)/A))
        print('Ккан1 = {0}'.format(self.handlers[0].total_task_count / self.iteration_count))
        print('Ккан2 = {0}'.format(Кkan2))

    def tick(self):

        self.current_tick += 1

        handler_result = self.handlers[1].tick()
        if handler_result is not None:
            self.handled_count += 1
            if len(self.queue) > 0:
                task = self.queue.dequeue()
                self.handlers[1].set_task(task)

        handler_result = self.handlers[0].tick()
        if handler_result is not None:
            if not self.handlers[1].is_busy():
                self.handlers[1].set_task(handler_result)
            else:
                if self.queue.has_place():
                    self.queue.enqueue(handler_result)
                else:
                    self.refused_count += 1

        source_result = self.source.tick()
        if source_result is not None:
            if not self.handlers[0].is_busy():
                self.handlers[0].set_task(source_result)
            else:
                self.refused_count += 1

        self.queue.tick()

        state = '{0}{1}{2}{3}'.format(
            str(self.source),
            str(self.handlers[0]),
            str(self.queue),
            str(self.handlers[1])
        )

        self.states.append(state)
        self.task_in_system_count += len(self.queue) + len(self.handlers[0]) + len(self.handlers[1])
