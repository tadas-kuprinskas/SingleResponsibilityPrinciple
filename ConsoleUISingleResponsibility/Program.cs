using System;

namespace ConsoleUISingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            //validation
            bool isUserValid = PersonValidator.Validate(user);

            if(!isUserValid)
            {
                StandardMessages.EndApplication();
                return;
            }

            //create a username for the person
            AccountGenerator.CreateAccount(user);
            StandardMessages.EndApplication();
        }
    }
}
