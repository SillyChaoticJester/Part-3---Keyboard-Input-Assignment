namespace Part_3___Keyboard_Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age, currentYear, birthYear;
            double distOne,distTwo, distThree, rightTriOne, rightTriTwo, rightTriTotal, addNumOne, addNumTwo, addNumThree, addTotal, distTotal;
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
            Math.Round(addTotal = addNumOne + addNumTwo + addNumThree, 2);
            Console.WriteLine($"Your total is {addTotal}");

            //3. Distance
            Console.WriteLine("Now give me three numbers for a distance, and I will print the average of them");
            distOne = Convert.ToDouble(Console.ReadLine());
            distTwo = Convert.ToDouble(Console.ReadLine());
            distThree = Convert.ToDouble(Console.ReadLine());
            distTotal = (distOne + distTwo + distThree) / 3;
            Console.WriteLine($"The average would be {Math.Round(distTotal, 2)} km");

            //4. Hypotenuse

            Console.WriteLine("Finally, type down two sides of a Right Triangle, and I will show you the hypotenuse:");
            rightTriOne = Convert.ToDouble(Console.ReadLine());
            rightTriTwo = Convert.ToDouble(Console.ReadLine());
            
            
        }
    }
}
