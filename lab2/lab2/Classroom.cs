using System.Collections.Generic;

namespace lab2
{
    public class Classroom
    {
        public Classroom(string name, Person[] persons)
        {
            this.name = name;
            this.persons = new List<Person>(persons);
        }

        private string name;

        private List<Person> persons;

        public string Name { get => name; }

        public override string ToString()
        {
            return name;
        }
    }
}
