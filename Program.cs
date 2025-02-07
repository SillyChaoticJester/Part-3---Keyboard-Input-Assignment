namespace Part_3___Keyboard_Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age, currentYear, birthYear;
            currentYear = DateTime.Now.Year;

            Console.WriteLine("Please write down your name:");
            name = Console.ReadLine();
            Console.WriteLine("Please write down your age:");
            age = Convert.ToInt32(Console.ReadLine());
            birthYear = currentYear - age;

            Console.WriteLine($"Hello {name}! You were born in {birthYear}! Wow!");
        }
    }
}
