using BranchProblem.Entities;

namespace BranchProblem.Business.Services.Abstract;

public interface IBranchService 
{
    Branch GetRootBranch();
    int CalculateDepth(Branch root); 
}
