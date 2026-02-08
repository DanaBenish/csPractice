// See https://aka.ms/new-console-template for more information
using OOPPractice;

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Alice");
        person1.Greet();

        Student student1 = new Student("Bob", 12345);
        student1.Greet();

        Intern intern1 = new Intern("Dave");
        intern1.Greet();
        intern1.Work();
    }
}
