namespace OOPPractice
{
    public class Student:Person
    {
        public int StudentID { get; set; }

        public Student(string name, int studentID) : base(name)
        {
            StudentID = studentID;
        }

        public override void Greet()
        {
            Console.WriteLine("Hello, my name is " + Name + " and my student ID is " + StudentID + '!');
        }
    }
}