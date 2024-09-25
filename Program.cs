namespace Topic_7_Assignment___Lists_Assignment
{
    //Christian
    internal class Program
    {
        static void Main(string[] args)
        {

            string vegName;
            int chooseVal;
            int menuChoice;
            int smallest, largest;
            int count;
            int listLength;
            int foundIndex = 0;
            double addUp, average;
            bool done = false;

            Random generator = new Random();
            List<int> numbers = new List<int>();
            List<string> veggies = new List<string>() { "CARROT", "BEET", "CELERY", "RADISH", "CABBAGE" };

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
                Console.WriteLine("6 - Find the largest number");
                Console.WriteLine("7 - Find the smallest number");
                Console.WriteLine("8 - Find the sum and average of all the numbers");
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
                        Console.WriteLine("That is not a valid input. Please input an integer you wish to remove from the list.");
                    }

                    if (chooseVal < 10 || chooseVal > 20)
                    {
                        Console.WriteLine("That value is outside the possible range of the list, and as such, there are no instances to remove.");
                        Console.WriteLine();
                    }
                    else
                    {
                        if (numbers.Contains(chooseVal))
                        {
                            numbers.RemoveAll(x => x == chooseVal);

                            Console.WriteLine($"All instances of {chooseVal} have been removed.");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine($"There are no instances of {chooseVal} in the list");
                            Console.WriteLine();
                        }
                    }
                }
                else if (menuChoice == 4)
                {
                    Console.WriteLine("Please input a value between 10-20 to add to the end of the list:");

                    while (!Int32.TryParse(Console.ReadLine(), out chooseVal) || chooseVal < 10 || chooseVal > 20)
                    {
                        Console.WriteLine("That is not a valid input. Please input an integer between 10-20 to add to the list.");
                    }

                    numbers.Add(chooseVal);

                    Console.WriteLine($"{chooseVal} has been added to the end of the list");
                    Console.WriteLine();
                }
                else if (menuChoice == 5)
                {
                    count = 0;

                    Console.WriteLine();
                    Console.WriteLine("What value would you like to count?");

                    while (!Int32.TryParse(Console.ReadLine().Trim(), out chooseVal))
                    {
                        Console.WriteLine("That is not a valid input. Please input a valid integer.");
                    }

                    if (chooseVal < 10 || chooseVal > 20)
                    {
                        Console.WriteLine($"{chooseVal} is outside the possible range of the list, and thus there are {count} instances of it");
                        Console.WriteLine();
                    }
                    else
                    {
                        foreach (int num in numbers)
                        {
                            if (num == chooseVal)
                            {
                                count++;
                            }
                        }

                        Console.WriteLine($"There are {count} instances of {chooseVal} in the list");
                        Console.WriteLine();
                    }
                }
                else if (menuChoice == 6)
                {
                    largest = 10;

                    foreach (int num in numbers)
                    {
                        if (num > largest)
                        {
                            largest = num;
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine($"The largest value in the list is {largest}");
                    Console.WriteLine();
                }
                else if (menuChoice == 7)
                {
                    smallest = 20;

                    foreach (int num in numbers)
                    {
                        if (num < smallest)
                        {
                            smallest = num;
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine($"The smallest value in the list is {smallest}");
                    Console.WriteLine();
                }
                else if (menuChoice == 8)
                {
                    addUp = 0;
                    average = 0;

                    foreach (int num in numbers)
                    {
                        addUp += num;
                    }

                    average = addUp / numbers.Count;

                    Console.WriteLine();
                    Console.WriteLine($"The sum of all the values in the list is {addUp}, and the average is {average}.");
                    Console.WriteLine();
                }
                else if (menuChoice == 9)
                {
                    done = true;

                    Console.WriteLine();
                    Console.WriteLine("Okay!");
                    Console.WriteLine();
                }
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();
                Console.Clear();
            }

            done = false;

            Console.WriteLine("Lists of Strings");
            Console.WriteLine();

            while (!done)
            {
                Console.WriteLine("Here is the list of vegetables:");
                Console.WriteLine();

                for (int i = 0; i <= veggies.Count - 1; i++)
                {
                    Console.WriteLine($"{i + 1} - {veggies[i]}");
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Choose an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Remove a vegetable by index");
                Console.WriteLine("2 - Remove a vegetable by name");
                Console.WriteLine("3 - Search for a vegetable");
                Console.WriteLine("4 - Add a vegetable");
                Console.WriteLine("5 - Sort the list");
                Console.WriteLine("6 - Clear the list");
                Console.WriteLine("7 - Quit");

                while (!Int32.TryParse(Console.ReadLine().Trim(), out menuChoice) || menuChoice <= 0 || menuChoice > 7)
                {
                    Console.WriteLine("That is not a valid choice. Please input the number corresponding to your choice from the menu above.");
                }

                if (menuChoice == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Input the index of the begetable you would like to remove. (The index in the menu, not the actual index)");

                    while (!Int32.TryParse(Console.ReadLine().Trim(), out chooseVal))
                    {
                        Console.WriteLine("That is not a valid input. Please input a valid integer.");
                    }

                    if (chooseVal <= 0 || chooseVal > veggies.Count)
                    {
                        Console.WriteLine("The list does not contain an item at that index, and thus I cannot remove it.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"Item number {chooseVal} - {veggies[chooseVal - 1]} has been removed");
                        Console.WriteLine();

                        veggies.RemoveAt(chooseVal - 1);
                    }
                }
                else if (menuChoice == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Type the name of the vegetable you wish to remove (does not need to be all capital letters)");

                    vegName = Console.ReadLine().Trim().ToUpper();

                    if (veggies.Contains(vegName))
                    {
                        veggies.Remove(vegName);

                        Console.WriteLine($"{vegName} has been removed.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"{vegName} does not exist in the list, and thus I can not remove it.");
                        Console.WriteLine();
                    }
                }
                else if (menuChoice == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Type the name of the vegetable you wish to search for (does not need to be all capital letters)");

                    vegName = Console.ReadLine().Trim().ToUpper();

                    if (veggies.Contains(vegName))
                    {
                        for (int i = 0; i <= veggies.Count - 1; i++)
                        {
                            if (veggies[i] == vegName)
                            {
                                foundIndex = i + 1;
                            }
                        }

                        Console.WriteLine($"{vegName} has been found at index {foundIndex} (Menu index, not actual index) ");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"{vegName} does not exist in the list.");
                        Console.WriteLine();
                    }
                }
                else if (menuChoice == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Type the name of the vegetable you want to add to the list:");

                    vegName = Console.ReadLine().Trim().ToUpper();

                    if (veggies.Contains(vegName))
                    {
                        Console.WriteLine($"I'm sorry, {vegName} already exists in the list, and I can't have duplicates.");
                        Console.WriteLine();
                    }
                    else
                    {
                        veggies.Add(vegName);

                        Console.WriteLine($"{vegName} has been added to the end of the list.");
                        Console.WriteLine();
                    }
                }
                else if (menuChoice == 5)
                {
                    veggies.Sort();

                    Console.WriteLine();
                    Console.WriteLine("The list has been sorted.");
                    Console.WriteLine();
                }
                else if (menuChoice == 6)
                {
                    veggies.Clear();

                    Console.WriteLine();
                    Console.WriteLine("The list has been cleared.");
                    Console.WriteLine();
                }
                else if (menuChoice == 7)
                {
                    done = true;

                    Console.WriteLine();
                    Console.WriteLine("Okay.");
                    Console.WriteLine();
                }

                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}