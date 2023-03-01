using BranchProblem.Business.Services.Abstract;
using BranchProblem.DataAccess.Abstract;
using BranchProblem.Entities;

namespace BranchProblem.Business.Services.Concrete;

public class BranchService : IBranchService
{
    private readonly IDatabase _db;

    public BranchService(IDatabase database)
    {
        _db = database;
    }

    public int CalculateDepth(Branch root)
    {
        if (root.branches.Count == 0)
            return 1;

        int maxDepth = 0;
        foreach (var branch in root.branches)
        {
            int currentDepth = CalculateDepth(branch);
            maxDepth = Math.Max(maxDepth, currentDepth);
        }

        return ++maxDepth;
    }

    public Branch GetRootBranch() => _db.RootBranch;
}