using System;
using System.Diagnostics.CodeAnalysis;

namespace lab2
{
    public class Person : IEquatable<Person>
    {
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        protected string name;

        protected int age;

        public string Name { get => name; }

        public int Age { get => age; }

        public bool Equals([AllowNull] Person other)
        {
            if (other == null)
            {
                return false;
            }

            if (other.name != name)
            {
                return false;
            }

            if (other.age != age)
            {
                return false;
            }

            return true;

        }

        public override string ToString()
        {
            return name + " (" + age.ToString() + " y.o.)";

        }
    }
}
