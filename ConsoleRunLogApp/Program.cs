using ConsoleRunLogApp;

Greeting();

string firstName = FirstName();
string lastName = LastName();
int myAge = MyAge();
string userEmail = UserEmail();
bool userAnswer = UserAnswer();

CreateNewUser(userAnswer, firstName, lastName, myAge, userEmail, userAnswer);


static void NextSteps()
{
    Console.Clear(); 
    Console.WriteLine("Okay so what would you like to do now? ");
    Console.WriteLine("----------------------------------------------");
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
    var userInput = Console.ReadLine();
 

}


static void CreateNewUser(bool userInput, string firstName,string lastName, int myAge, string userEmail, bool userAnswer)
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
        NextSteps();
    }
    else
    {
        CloseTheProgram();
    }
}

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
