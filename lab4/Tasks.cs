using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    namespace Tasks
    {
        public enum Status
        {
            Backlog,
            InProgress,
            Review,
            Done
        }

        public class Task
        {
            public string name;
            public string description;
            public Status status;


            public DateTime dueTo;
            public Tester assignee = null;

            public Task(string name, string description, Status status, DateTime dueTo)
            {
                this.dueTo = dueTo;
                this.name = name;
                this.description = description;
                this.status = status;
            }

            public override string ToString()
            {
                var assigneeName = assignee == null || assignee.name == "" ? "none" : assignee.name;

                return string.Format("Name: {0} | Description: {1} | Status: {2} | Assignee: {3} | Due to: {4}",
                                      name, description, status, assigneeName, dueTo);
            }

        }

        public class Tester
        {
            public Tester(string name)
            {
                this.name = name;
            }

            public string name;
        }

        public class Tracker
        {
            public Dictionary<string, Task> tasks = new Dictionary<string, Task>();
            public Dictionary<string, Tester> testers = new Dictionary<string, Tester>();

            public bool AddTask(in Task task)
            {
                if (tasks.ContainsKey(task.name))
                {
                    return false;
                }
                tasks.Add(task.name, task);
                return true;
            }

            public bool AddTester(in Tester tester)
            {
                if (testers.ContainsKey(tester.name))
                {
                    return false;
                }
                testers.Add(tester.name, tester);
                return true;
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
                return tasks.Values.Where(task => task.assignee?.name == testerName).ToArray();
            }
        }
    }
}
