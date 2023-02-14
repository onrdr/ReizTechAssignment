
namespace ClockAngleProblem.Business.Utilities.Messages;

public static class Display
{
    public static void WelcomeMessage()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();
        Console.WriteLine(@"
=========================================
Welcome to Clock Angle Finder Application
=========================================");
    }

    public static void InputMessage(string strVal)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write($"\nPlease enter the {strVal} (Press 'E' to Exit) : ");
    }

    public static void NotInRangeWarning(string strVal, int min, int max)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"The value for {strVal} should be between {min} - {max} (both included)");
    }

    public static void ExceptionMessage(Exception e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{e.Message} Please try again");
    }

    public static void SystemClosingMessage()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        int counter = 3;        

        while (counter > 0)
        {
            Console.Clear();
            Console.Write($"\nSystem is Closing in {counter--}"); 
            Thread.Sleep(1000);
        }
        Environment.Exit(0);
    }

    public static void ResultMessage(double result)
    {
        Console.ForegroundColor = ConsoleColor.Green; 
        Console.WriteLine($"\nThe lesser angle is : {result}\u00B0"); 
    }

    public static void ExitChoiceMessage()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nEnter R to RESTART the program or any key to EXIT");
    }
}
