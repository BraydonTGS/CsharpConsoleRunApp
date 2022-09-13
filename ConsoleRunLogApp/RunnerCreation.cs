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
        private double milesRun; 
        private double weeklyGoal;   
       


        public RunnerCreation(string fName, string lName, int age, string email, string uPassword)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.userAge = age;
            this.email = email;
            this.password = uPassword;
            this.milesRun = 0.0;
            this.weeklyGoal = 0.0; 
            Console.Write("Success! Your Account Has Been Created ");
            Console.WriteLine(); 
            Console.WriteLine("----------------------------------------------");

        }

       // Getters //
       public double getMilesRun()
        {
            return milesRun; 
        }

       public double getWeeklyGoal()
        {
            return weeklyGoal; 
        }

       // Setters //
       public void setMilesRun(double miles)
        {
            milesRun = miles; 
        }

       public void setWeeklyGoal(double goal)
        {
            weeklyGoal = goal; 
        }


       
    }
}

