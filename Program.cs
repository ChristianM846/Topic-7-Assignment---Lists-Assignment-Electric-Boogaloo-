namespace Topic_7_Assignment___Lists_Assignment
{
    //Christian
    internal class Program
    {
        static void Main(string[] args)
        {


            int chooseVal;
            int menuChoice;
            int addUp;
            bool done = false;


            Random generator = new Random();
            List<int> numbers = new List<int>();

            Console.WriteLine("Lists of Integers");
            Console.WriteLine();

            for (int i = 0; i <= 24; i++)
            {
                numbers.Add(generator.Next(10, 21));
            }

            while (!done)
            {
                Console.WriteLine("Here is the list of integers:");
                Console.WriteLine();
                
                foreach (int number in numbers)
                {
                    Console.Write($"{number}, ");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Choose an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Sort the list");
                Console.WriteLine("2 - Make a new list (will have the same number of items)");
                Console.WriteLine("3 - Remove a number (by value)");
                Console.WriteLine("4 - Add a value to the list");
                Console.WriteLine("5 - Sort the list");
                Console.WriteLine("6 - Sort the list");
                Console.WriteLine("7 - Sort the list");
                Console.WriteLine("8 - Sort the list");
                Console.WriteLine("9 - Sort the list");
                Console.WriteLine("10 - Sort the list");




                Console.ReadLine();
            }




        }
    }
}
