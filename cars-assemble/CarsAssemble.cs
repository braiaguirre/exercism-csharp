using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed >= 1 && speed <= 4) return 1.00;
        if (speed >= 5 && speed <= 8) return 0.90;
        if (speed == 9) return 0.80;
        if (speed == 10) return 0.77;
        return 0;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return (speed * 221) * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return Convert.ToInt32(ProductionRatePerHour(speed)) / 60;
    }
}
