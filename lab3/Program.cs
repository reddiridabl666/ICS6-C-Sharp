using Tasks;

namespace Tasks
{
    enum Status
    {
        Backlog,
        InProgress,
        Review,
        Done
    }

    struct Task(string name, string description, Status status, DateTime dueTo)
    {
        public string name = name;
        public string description = description;
        public Status status = status;


        public DateTime dueTo = dueTo;
        public Tester assignee;

        public override readonly string ToString()
        {
            return string.Format("Name: {0} | Description: {1} | Status: {2} | Assignee: {3} | Due to: {4}",
                                  name, description, status, assignee.name == "" || assignee.name == null ? "none" : assignee.name, dueTo);
        }

    }

    struct Tester(string name)
    {
        public string name = name;
    }

    class Tracker
    {
        private Dictionary<string, Task> tasks = [];
        private Dictionary<string, Tester> testers = [];

        public void AddTask(in Task task)
        {
            tasks.Add(task.name, task);
        }

        public void AddTester(in Tester tester)
        {
            testers.Add(tester.name, tester);
        }

        public bool AssignTask(string taskName, string testerName)
        {
            try
            {
                var task = tasks[taskName];
                task.assignee = testers[testerName];
                tasks[taskName] = task;
            }
            catch (KeyNotFoundException)
            {
                return false;
            }

            return true;
        }

        public bool SetStatus(string taskName, Status status)
        {
            try
            {
                var task = tasks[taskName];
                task.status = status;
                tasks[taskName] = task;
            }
            catch (KeyNotFoundException)
            {
                return false;
            }

            return true;
        }

        public Task[] List(string testerName)
        {
            return tasks.Values.Where(task => task.assignee.name == testerName).ToArray();
        }
    }
}

class Program
{
    static string availableCommands = @"Available commands are:
    add_tester add_task set_status assign list help end";

    static Tracker tracker = new();

    static Dictionary<string, Action<string[]>> handlers = new()
    {
        ["help"] = (string[] _) => Console.WriteLine(availableCommands),
        ["add_tester"] = (string[] args) =>
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Number of args should be 1");
                return;
            }
            tracker.AddTester(new Tester(args[0]));
        },
        ["add_task"] = (string[] args) =>
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Number of args should be 3");
                return;
            }
            tracker.AddTask(
                new Tasks.Task(
                    args[0],
                    args[1],
                    Status.Backlog,
                    DateTime.Parse(args[2])
                ));
        },
        ["assign"] = (string[] args) =>
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Number of args should be 2");
                return;
            }
            if (!tracker.AssignTask(args[0], args[1]))
            {
                Console.WriteLine("Task or tester does not exist");
            }
        },
        ["list"] = (string[] args) =>
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Number of args should be 1");
                return;
            }
            foreach (var task in tracker.List(args[0]))
            {
                Console.WriteLine(task);
            }
        },
        ["set_status"] = (string[] args) =>
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Number of args should be 2");
                return;
            }
            if (!tracker.SetStatus(args[0], (Status)Enum.Parse(Status.Backlog.GetType(), args[1])))
            {
                Console.WriteLine("Task does not exist");
            }
        }
    };

    static int Main()
    {
        Console.WriteLine(availableCommands);

        string? input = Console.ReadLine();

        for (; input != null && input != "end"; input = Console.ReadLine())
        {
            var parts = input.Split(' ', 2);
            var cmd = parts[0];

            var args = parts.Length > 1 ? parts[1].Split() : [];

            if (!handlers.TryGetValue(cmd, out var handler))
            {
                Console.WriteLine("Unknown command '{0}'", cmd);
                continue;
            }

            try
            {
                handler(args);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception: {0}", e.Message);
            }
        }

        return 0;
    }
}
