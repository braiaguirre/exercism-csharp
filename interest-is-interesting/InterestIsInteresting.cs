using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance) =>
        balance switch {
                >= 5000 => 2.475f,
                >= 1000 => 1.621f,
                >= 0 => 0.5f,
                < 0 => 3.213f
        };

    public static decimal Interest(decimal balance) => balance * (decimal)InterestRate(balance) / 100;

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance) => 
        (targetBalance > balance) ? 1 + YearsBeforeDesiredBalance(AnnualBalanceUpdate(balance), targetBalance) : 0;
}
