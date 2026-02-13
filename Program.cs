using System;
namespace Labi
{
    class Program
    {

        static void Main(string[] args) {
            iPad sorry = new iPad();
            sorry.CreationYear();
            sorry.Designer();
            sorry.Years_since_creation();
            sorry.Revenue_for_2025();
        }

    }

    class Apple
    {
        public string DeviceType { get; set; }
        public string Assembly { get; set; }

        public string Packaging { get; set; }

        public string Design { get; set; }

        public void Slogan()
        {
            Console.WriteLine("Think Different");
        }

        public void Office()
        {
            Console.WriteLine("Apple Park, Cupertino");
        }

        public virtual void CreationYear()
        {
            Console.WriteLine("The Apple company appeared in 1976");

        }

        public virtual void Designer()
        {
            Console.WriteLine("Designer of Apple was Ronald Wayne");
        }

        public void Years_since_creation()
        {
            Console.WriteLine("50 years since creation company");
        }

        public void Revenue_for_2025()
        {
            Console.WriteLine("Apple revenue for 2025 was $416.16 billion");
        }
    }
    class iPad : Apple
    {
        public string Model { get; set; }
        public string ReleaseYear { get; set; }

        public override void CreationYear()
        {
            Console.WriteLine("The first iPad appeared in 2010");
        }
        public override void Designer()
        {
            Console.WriteLine("Designer of iPad was Jony Ive");
        }

        public new void Years_since_creation()
        {
            Console.WriteLine("16 years since creation iPad");
        }
        public new void Revenue_for_2025()
        {
            Console.WriteLine("iPad revenue for 2025 was $$8.6 billion");
        }
    }
}
