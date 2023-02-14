using BranchProblem.Entities;

namespace BranchProblem.Business.Services.Abstract;

public interface IBranchService 
{
    int CalculateDepth(Branch root);
    void LoadDatabase();
    Branch GetRootBranch();
}
