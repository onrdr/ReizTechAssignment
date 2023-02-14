using ClockAngleProblem.Business.Services.Abstract;
using ClockAngleProblem.Business.Services.Concrete;
using ClockAngleProblem.Application.Abstract;
using ClockAngleProblem.Application.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace ClockAngleProblem.Application.IoC;

public class MicrosoftContainer
{
    public static IServiceProvider ConfigureService()
    {
        var provider = new ServiceCollection()
            .AddSingleton<IUserInputService, UserInputService>()
            .AddSingleton<ICalculatorService, AngleCalculatorService>()
            .AddSingleton<IApplication, AngleApplication>()
            .BuildServiceProvider();

        return provider;
    }
}
