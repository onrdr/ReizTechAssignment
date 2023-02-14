using ClockAngleProblem.Business.Services.Abstract;
using ClockAngleProblem.Business.Utilities.Messages;

namespace ClockAngleProblem.Business.Services.Concrete;

public class UserInputService : IUserInputService
{ 
    public int GetValidNumber(string strVal, int min, int max)
    {
        int userInput;

        while (true)
        {
            try
            {
                Display.InputMessage(strVal);
                string tempUserInput = Console.ReadLine().ToUpper();

                if (tempUserInput is "E") 
                    Display.SystemClosingMessage(); 

                userInput = Convert.ToInt32(tempUserInput); 

                if (userInput >= min && userInput <= max)
                    break;

                Display.NotInRangeWarning(strVal, min, max); 
            }
            catch (Exception e)
            {
                Display.ExceptionMessage(e);
            }
        }

        return userInput;
    }

    public void GetUserExitStrategy()
    {
        Display.ExitChoiceMessage();
        string choice = Console.ReadLine().ToUpper();
        if (choice is not "R")
            Display.SystemClosingMessage();
    }
}