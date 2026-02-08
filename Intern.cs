namespace OOPPractice
{
    public class Intern: Person, IWorker
    {
        public Intern(string name) : base(name) {}

        public void Work()
        {
            Console.WriteLine($"{Name} is working on tasks");
        }
    }
}