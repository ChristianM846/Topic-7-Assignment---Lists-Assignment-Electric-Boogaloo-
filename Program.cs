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




                Console.ReadLine();
            }




        }
    }
}
