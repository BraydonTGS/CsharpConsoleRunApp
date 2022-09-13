using ConsoleRunLogApp;

Greeting();
RunnerAccounts runners = new RunnerAccounts();

string firstName = FirstName();
string lastName = LastName();
int myAge = MyAge();
string userEmail = UserEmail();
bool userAnswer = UserAnswer();

CreateNewUser(userAnswer, firstName, lastName, myAge, userEmail, userAnswer);

// User Choice //
static void UserChoice(string input, RunnerCreation newUser)
{
    switch (input)
    {
        case "1":
            Console.Clear();
            try
            {
                Console.Write("How many miles did you run today? ");
                double milesRun = Convert.ToDouble(Console.ReadLine());
                newUser.setMilesRun(milesRun + newUser.getMilesRun());
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Nice Job! Keep working hard");
                Console.ReadLine();
                PrintOptions(newUser);
                break;
            }
            catch (Exception e)
            {
                Console.Write("Please enter a number and try again! ");
                Console.ReadLine();
                UserChoice(input, newUser);
                break;
            }
        case "2":
            Console.Clear();
            Console.WriteLine($"Your running goal for this week is {newUser.getWeeklyGoal()} miles!");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"You have run {newUser.getMilesRun()} miles so far this week!");
            Console.WriteLine("----------------------------------------------");
            Console.Write($"You have {newUser.getWeeklyGoal() - newUser.getMilesRun()} miles left to run to met your goal!");
            Console.ReadLine();
            PrintOptions(newUser);
            break;
        case "3":
            try
            {
                Console.Clear();
                Console.WriteLine($"Your Current Weekly Goal is {newUser.getWeeklyGoal()}");
                Console.WriteLine("----------------------------------------------");
                Console.Write("How many miles are you going to run this week? ");
                double mileGoals = Convert.ToDouble(Console.ReadLine());
                newUser.setWeeklyGoal(mileGoals);
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Wow! Thats a lot of miles");
                Console.ReadLine();
                PrintOptions(newUser);
                break;
            }
            catch
            {
                Console.Write("Please enter a number and try again! ");
                Console.ReadLine();
                UserChoice(input, newUser);
                break;
            }


    }
}

// Print Options // 
static void PrintOptions(RunnerCreation newUser)
{
    Console.Clear();
    Console.WriteLine("Select operation: ");
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("1. Add a New Run");
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("2. Display Weekly Run Log");
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("3. Update Weekly Run Goal");
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("4. Exit");
    Console.WriteLine();
    Console.Write("Please Enter your Seleciton: ");
    string userInput = Console.ReadLine();
    UserChoice(userInput, newUser);

}

// Creating a new instace of a user //
static void CreateNewUser(bool userInput, string firstName, string lastName, int myAge, string userEmail, bool userAnswer)
{
    if (userInput == true)
    {
        Console.Write("Please Enter a password: ");
        string userPassword = Console.ReadLine();
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Okay, Please Wait While your account is created... ");
        Console.WriteLine("----------------------------------------------");
        Thread.Sleep(2500);
        RunnerCreation newUser = new RunnerCreation(firstName, lastName, myAge, userEmail, userPassword);
        PrintOptions(newUser);
    }
    else
    {
        CloseTheProgram();
    }
}

// Getting The User Input Code Below // 
static bool UserAnswer()
{
    Console.Write("Would you like to create a new Account (Y/N)? ");
    string answer = Console.ReadLine().ToUpper();
    Console.WriteLine("----------------------------------------------");
    if (answer == "Y")
    {
        bool newAnswer = true;
        return newAnswer;
    }
    else
    {
        bool newAnswer = false;
        return newAnswer;
    }

}

static string UserEmail()
{
    Console.Write("Please Enter your Email Address: ");
    string email = Console.ReadLine();
    Console.WriteLine("----------------------------------------------");
    return email;
}

static int MyAge()
{
    try
    {
        Console.Write("Please Enter your Age: ");
        int myAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("----------------------------------------------");
        return myAge;
    }
    catch
    {
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("There was an Error.");
        Console.WriteLine();
        Console.WriteLine("Please Try Again and Enter a Number. ");
        Console.WriteLine("----------------------------------------------");
        return MyAge();
    }
}

static string LastName()
{
    Console.Write("Please Enter your Last Name: ");
    string lastName = Console.ReadLine();
    Console.WriteLine("----------------------------------------------");
    return lastName;
}

static string FirstName()
{
    Console.Write("Please Enter your First Name: ");
    string firstName = Console.ReadLine();
    Console.WriteLine("----------------------------------------------");
    return firstName;
}

static void CloseTheProgram()
{
    Console.Write("Okay, Thank you. ");
    Console.ReadLine();
}

static void Greeting()
{
    Console.Write("Welcome to RunDogs! Press any Key to Continue. ");
    Console.ReadLine();
    Console.WriteLine("----------------------------------------------");

}
