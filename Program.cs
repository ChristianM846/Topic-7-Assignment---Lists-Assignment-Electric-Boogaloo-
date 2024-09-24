namespace Topic_7_Assignment___Lists_Assignment
{
    //Christian
    internal class Program
    {
        static void Main(string[] args)
        {


            int chooseVal;
            int menuChoice;
            int addUp, average;
            int smallest, largest;
            int listLength;
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
                Console.WriteLine("2 - Make a new list (will have the same number of values)");
                Console.WriteLine("3 - Remove a number (by value - all instances)");
                Console.WriteLine("4 - Add a value to the list");
                Console.WriteLine("5 - Count the number of occurrences of a specified value");
                Console.WriteLine("6 - Print the largest number");
                Console.WriteLine("7 - Print the smallest number");
                Console.WriteLine("8 - Print the sum and average of all the numbers");
                Console.WriteLine("9 - Quit (And move on to part 2)");

                while (!Int32.TryParse(Console.ReadLine().Trim(), out menuChoice) || menuChoice <= 0 || menuChoice > 9)
                {
                    Console.WriteLine("That is not a valid choice. Please input the number corresponding to your choice from the menu above.");
                }

                if (menuChoice == 1)
                {
                    numbers.Sort();
                    Console.WriteLine();
                    Console.WriteLine("The list has been sorted.");
                    Console.WriteLine();
                }
                else if (menuChoice == 2)
                {
                    listLength = numbers.Count - 1;
                    numbers.Clear();

                    for (int i = 0; i <= listLength; i++)
                    {
                        numbers.Add(generator.Next(10, 21));
                    }

                    Console.WriteLine();
                    Console.WriteLine($"The list has been remade with {numbers.Count} values.");
                    Console.WriteLine();
                }
                else if (menuChoice == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Choose a value to remove from the list. (List contains numbers from 10-20)");

                    while (!Int32.TryParse(Console.ReadLine().Trim(), out chooseVal))
                    {
                        Console.WriteLine("That is not a valid input, please input an integer you wish to remove from the list.");
                    }

                    if (chooseVal < 10 || chooseVal > 20)
                    {
                        Console.WriteLine("That value is outside the possible range of the list, and as such, there are no instances to remove.");
                    }
                    else
                    {
                        if (numbers.Contains(chooseVal))
                        {
                            numbers.RemoveAll(x => x == chooseVal);
                        }
                    }




                }
                else if (menuChoice == 4)
                {

                }
                else if (menuChoice == 5)
                {

                }
                else if (menuChoice == 6)
                {

                }
                else if (menuChoice == 7)
                {

                }
                else if (menuChoice == 8)
                {

                }
                else if (menuChoice == 9)
                {

                }






                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();
                Console.Clear();
            }




        }
    }
}
