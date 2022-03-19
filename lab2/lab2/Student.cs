using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace lab2
{
    public class Student : Person
    {
        public Student(string name, int age, string group) : base(name, age)
        {
            this.group = group;
            this.tasks = new List<Task>();
        }

        public Student(string name, int age, string group, List<Task> tasks) : base(name, age)
        {
            this.group = group;
            this.tasks = tasks;
        }

        protected string group;

        protected List<Task> tasks;

        public string Group { get => group; }

        public void AddTask(string taskName, TaskStatus status)
        {
            Task task = new Task(taskName, status);

            tasks.Add(task);
        }

        public void RemoveTask(int index)
        {
            tasks.RemoveAt(index);
        }

        public void UpdateTask(int index, TaskStatus status)
        {
            Task oldTask = tasks[index];
            Task newTask = new Task(oldTask.Name, status);

            tasks[index] = newTask;
        }
        public string RenderTasks(string prefix = "\t")
        {
            string text = "";
            foreach (Task task in tasks)
            {
                text += prefix + task.ToString() + "\n";
            }

            return text;
        }

        public override string ToString()
        {
            return base.ToString() + " " + group;
        }

        public bool Equals([AllowNull] Student other)
        {
            if (other == null)
            {
                return false;
            }

            if (!base.Equals(other))
            {
                return false;
            }

            if (other.group != group)
            {
                return false;
            }

            if (!SequenceEquals(other.tasks, tasks))
            {
                return false;
            }

            return true;
        }

        private bool SequenceEquals<T>(List<T> a, List<T> b) where T : System.IEquatable<T>
        {


            if (a.Count != b.Count)
            {
                return false;
            }

            for (int i = 0; i < tasks.Count; i++)
            {
                if (!a[i].Equals(b[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
