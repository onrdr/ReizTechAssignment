using BranchProblem.Business.Services.Abstract;
using BranchProblem.Business.Services.Concrete;
using BranchProblem.DataAccess.Abstract;
using BranchProblem.DataAccess.Concrete;
using BranchProblem.Application.Abstract;
using BranchProblem.Application.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace BranchProblem.Application.IoC;

public class MicrosoftContainer
{
    public static IServiceProvider ConfigureService()
    {
        var provider = new ServiceCollection()
            .AddSingleton<IDatabase, BranchesDb>()
            .AddSingleton<IBranchService, BranchService>()
            .AddSingleton<IApplication, BranchApplication>()
            .BuildServiceProvider();

        return provider;
    }
}
