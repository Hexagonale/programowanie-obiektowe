using System;
using System.Diagnostics.CodeAnalysis;

namespace lab2
{
    public class Task : IEquatable<Task>
    {
        public Task(string name, TaskStatus status)
        {
            this.name = name;
            this.status = status;
        }

        private string name;

        private TaskStatus status;

        public string Name { get => name; }

        public TaskStatus Status { get => status; }

        public bool Equals([AllowNull] Task other)
        {
            if (other == null)
            {
                return false;
            }

            if (other.name != name)
            {
                return false;
            }

            if (other.status != status)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return name + " " + status.ToString();
        }
    }

    public enum TaskStatus
    {
        Waiting,
        Progress,
        Done,
        Rejected
    }
}
