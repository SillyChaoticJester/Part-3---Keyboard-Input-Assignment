namespace Part_3___Keyboard_Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age, currentYear, birthYear;
            double distOne,distTwo, distThree, rightTriOne, rightTriTwo, addNumOne, addNumTwo, addNumThree, total;
            currentYear = DateTime.Now.Year;

            //1. Greeting
            Console.WriteLine("Please write down your name:");
            name = Console.ReadLine();
            Console.WriteLine("Please write down your age:");
            age = Convert.ToInt32(Console.ReadLine());
            birthYear = currentYear - age;

            Console.WriteLine($"Hello {name}! You were born in {birthYear}! Wow!");

            //2. Adder
            Console.WriteLine("Now type down three numbers, and I will say its total.");
            addNumOne = Convert.ToDouble(Console.ReadLine());
            addNumTwo = Convert.ToDouble(Console.ReadLine());
            addNumThree = Convert.ToDouble(Console.ReadLine());
            total = addNumOne + addNumTwo + addNumThree;
            Console.WriteLine($"Your total is {total}");


        }
    }
}
