namespace ThrowBall
{
    public class Ball : System.Exception { }

    public class Person
    {
        public Person target;
        public String name;

        public Person(Person target, string name)
        {
            this.target = target;
            this.name = name;
        }

        public override String ToString()
        {
            return name;
        }

        public void Aim(Ball ball)
        {
            try
            {
                Console.WriteLine(this + " : throw ball");
                throw ball;
            }
            catch (Ball b)
            {
                Console.WriteLine(target + " : Catch ball");
                target.Aim(b);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person parent = new Person(null, "Parent");
            Person child = new Person(parent, "Child");
            parent.target = child;
            parent.Aim(new Ball());
        }
    }
}