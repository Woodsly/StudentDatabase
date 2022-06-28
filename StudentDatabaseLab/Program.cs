//Introduction
Console.WriteLine("Welcome to the Grand Circus Student Database!");
bool runProgram = true;
while (runProgram)
{
    //Arrays
    string[] students = { "Justin Jones", "Connor Wood", "Kris Pranger", "Josh Carolin", "Krista Anderson", "Travis Amador", "Asia Drew", "Ali Al-Hashemi", "Vinh Dang", "Tolulope Olubunmi", "Robot Haupt", "Matt Fox", "Daniel Schuler", "Anthony Ventura", "Mara Johnson", "Brandon Harman", "Olukayode Olubunmi" };
    string[] favFoods = { "Baja Blast", "Chicken Sandwich", "Sushi", "Nalesniki", "sushi", "General Tso's", "Jerk Chicken", "Steak", "sushi", "Rice and Dodo", "Bread", "Steak", "BBQ", "Thai", "Tacos", "Pasta", "Pounded Yam" };
    string[] homeTowns = { "Wyoming, MI", "Grosse Pointe, MI", "Grosse Pointe, MI", "Westland, MI", "Grosse Ile, MI", "Brown City, MI", "Detroit, MI", "Dearborn Heights, MI", "Shelby, MI", "Asese, Nigeria", "Green Bay, WI", "Sterling Heights, MI", "Potterville, MI", "Canton,MI", "Rochester, MI", "Dallas, TX", "Ibadan, Nigeria" };
    while (true)
    {
        Console.WriteLine("Would you like to see a list of all available students? \"y\" or \"n\"");
        string allStudents = Console.ReadLine().ToLower().Trim();
        if (allStudents == "y")
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}: {students[i]}");
            }
            break;
        }
        else if (allStudents == "n")
        {
            break;
        }
        else
        {
            Console.WriteLine("Please make a valid selection");
        }
    }
    Console.WriteLine("Which student would you like to learn more about?  Please enter a number 1-17");
    int student;
    while (true)
    {
        student = int.Parse(Console.ReadLine());
        if (student <= 0 || student > students.Length)
        {
            Console.WriteLine("Please make a valid selection 1-17!");
        }
        else
        {
            break;
        }
    }

    int index = student - 1;
    Console.WriteLine($"Student number: {student} is {students[index]}!");
    Console.WriteLine("What more would you like to know about them? Enter \"hometown\" or \"favorite food\"");
    while (true)
    {
        string moreInfo = Console.ReadLine().ToLower().Trim();
        if (moreInfo == "hometown")
        {
            Console.WriteLine($"{students[index]} lives in {homeTowns[index]}.");
            break;
        }
        else if (moreInfo == "favorite food")
        {
            Console.WriteLine($"{students[index]} loves to eat {favFoods[index]}!");
            break;
        }
        else
        {
            Console.WriteLine("Please make a valid choice... \"hometown\" or \"favorite food\"");
        }
    }
    while (true)
    {
        Console.WriteLine("Would you like to learn about another student? Enter \"y\" or \"n\"");
        string rerun = Console.ReadLine().ToLower().Trim();
        if (rerun == "y")
        {
            break;
        }
        else if(rerun == "n")
        {
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Please enter a valid answer.");
        }
    }
}
Console.WriteLine("Thanks for checking out the Student Database!  Have an amazing day.");