using BranchProblem.Business.Services.Abstract;
using BranchProblem.Application.Abstract;

namespace BranchProblem.Application.Concrete;

public class BranchApplication : IApplication
{
    private readonly IBranchService _service;

    public BranchApplication(IBranchService service)
    {
        _service = service;
    }

    public void Run()
    { 
        var root = _service.GetRootBranch();
        int depth = _service.CalculateDepth(root);
        Console.WriteLine($"The depth is: {depth}");
    }
}
