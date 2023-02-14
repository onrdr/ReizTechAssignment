using ClockAngleProblem.Application.Abstract;
using Microsoft.Extensions.DependencyInjection;
using ClockAngleProblem.Application.IoC;



var container = MicrosoftContainer.ConfigureService();

var angleApp = container.GetRequiredService<IApplication>();

angleApp.Run(); 




