using System;
namespace ConsoleRunLogApp
{
    public class RunnerCreation
    {
        private string firstName;
        private string lastName;
        private int userAge;
        private string email;
        private string password; 

        public RunnerCreation(string fName, string lName, int age, string email, string uPassword)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.userAge = age;
            this.email = email;
            this.password = uPassword; 
            Console.Write("Success! Your Account Has Been Created ");
            Console.WriteLine(); 
            Console.WriteLine("----------------------------------------------");


        }
    }
}

