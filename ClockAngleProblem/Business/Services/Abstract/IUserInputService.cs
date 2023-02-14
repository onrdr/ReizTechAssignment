 
namespace ClockAngleProblem.Business.Services.Abstract;

public interface IUserInputService  
{ 
    int GetValidNumber(string strVal, int min, int max);
    void GetUserExitStrategy();
}