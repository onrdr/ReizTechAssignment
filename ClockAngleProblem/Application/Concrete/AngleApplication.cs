using ClockAngleProblem.Business.Services.Abstract;
using ClockAngleProblem.Business.Utilities.Messages;
using ClockAngleProblem.Application.Abstract;

namespace ClockAngleProblem.Application.Concrete;

public class AngleApplication : IApplication
{
    private readonly IUserInputService _userInputService;
    private readonly ICalculatorService _calculatorService;

    public AngleApplication(IUserInputService userInputService, ICalculatorService calculatorService)
    {
        _userInputService = userInputService;
        _calculatorService = calculatorService;
    }

    public void Run()
    {
        while (true)
        {
            Display.WelcomeMessage();

            int hour = _userInputService.GetValidNumber("hour", 0, 23);
            int minute = _userInputService.GetValidNumber("minute", 0, 59);
            double result = _calculatorService.CalculateAngle(hour, minute);
            Display.ResultMessage(result);

            _userInputService.GetUserExitStrategy();
        }
    }
}