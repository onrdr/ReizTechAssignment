using BranchProblem.DataAccess.Abstract;
using BranchProblem.Entities;

namespace BranchProblem.DataAccess.Concrete;

public class BranchesDb : IDatabase
{ 
    public Branch RootBranch { get; }

    public BranchesDb()
    {
        RootBranch = new Branch();

        Branch b1 = new();
        RootBranch.branches.Add(b1);

        Branch b2 = new();
        RootBranch.branches.Add(b2);

        Branch b3 = new();
        b1.branches.Add(b3);

        Branch b4 = new();
        b2.branches.Add(b4);

        Branch b5 = new();
        b2.branches.Add(b5);

        Branch b6 = new();
        b2.branches.Add(b6);

        Branch b7 = new();
        b4.branches.Add(b7);

        Branch b8 = new();
        b5.branches.Add(b8);

        Branch b9 = new();
        b5.branches.Add(b9);

        Branch b10 = new();
        b8.branches.Add(b10);
    } 
}
