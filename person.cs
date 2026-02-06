namespace OOPPractice
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person(string name)
        {
            this.name = name;
        }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is " + name + '!');
        }
    }
}