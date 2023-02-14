using BranchProblem.Entities;

namespace BranchProblem.DataAccess.Abstract;

public interface IDatabase
{
    void LoadData();
    Branch GetRootBranch();
}
