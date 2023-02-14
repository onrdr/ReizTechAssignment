using BranchProblem.Application.Abstract;
using Microsoft.Extensions.DependencyInjection;
using BranchProblem.Application.IoC;



var container = MicrosoftContainer.ConfigureService();

var branchApp = container.GetRequiredService<IApplication>();

branchApp.Run();
 

  
Console.ReadLine();

