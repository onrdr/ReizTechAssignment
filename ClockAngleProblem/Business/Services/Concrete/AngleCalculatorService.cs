using ClockAngleProblem.Business.Services.Abstract;

namespace ClockAngleProblem.Business.Services.Concrete;

public class AngleCalculatorService : ICalculatorService
{
    public double CalculateAngle(int hour, int minute)
    { 
        if (hour >= 12) 
            hour -= 12; 
 
        double degreeShiftOfHourCausedByMinute = (double)minute / 2;     
        double positionOfHourArrowInDegree = (hour * 30) + degreeShiftOfHourCausedByMinute;
        double positionOfMinuteArrowInDegree = minute * 6;

        double angle = Math.Abs(positionOfMinuteArrowInDegree - positionOfHourArrowInDegree);
        angle = Math.Min(360 - angle, angle);

        return angle;
    }

    #region Explanation for Algorithm

    /* 
        - If the value of minute increases by 1 minute then the angle of minute increases by 6 degrees
          and the angle of hour increases by 0.5 degrees because of the movement of the minute
          If the value of hour increases by 1 hour, the angle of hour increases by 30 degrees
        
        - Both positionOfHourArrowInDegree and positionOfHourArrowInDegree are relative to 
          number 12 at the analogue clock (top of the clock)
     */
    #endregion
}