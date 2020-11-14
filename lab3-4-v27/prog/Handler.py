import random

class Handler:

    def __init__(self, probability, generator):
        self.probability = probability
        self.generator = generator
        self.total_task_count = 0
        self.task = None

    def tick(self):

        if not self.is_busy():
            return None

        self.total_task_count += 1
        ev = random.random()
        if ev <= self.probability:
            return None
        else:
            task = self.task
            self.task = None
            return task
            
    def set_task(self, task):
        self.task = task

    def is_busy(self):
        return self.task is not None

    def __len__(self):
        return 1 if self.is_busy() else 0

    def __str__(self):
        return '1' if self.is_busy() else '0'
