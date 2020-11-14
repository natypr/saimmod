from Task import Task

class Source:

    def __init__(self):
        self.current_tick = 1
        self.first_time = True
        self.total_task_count = 0

    def tick(self):

        if self.current_tick == 1:
            self.current_tick += 1
            if not self.first_time:
                self.total_task_count += 1
                return Task()
            self.first_time = False
        else:
            self.current_tick -= 1
            return None

    def __str__(self):
        return str(self.current_tick)
