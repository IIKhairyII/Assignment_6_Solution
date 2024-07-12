namespace Assignment_6
{
    public struct Person
    {
        public string Name { get; set; }
        public float Age { get; set; }
        public Person(string name, float age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"Name = {Name}, Age = {Age}";
        }
    }
}
