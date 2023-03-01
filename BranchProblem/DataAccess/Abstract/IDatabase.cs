using BranchProblem.Entities;

namespace BranchProblem.DataAccess.Abstract;

public interface IDatabase
{
    public Branch RootBranch { get;} 
}
