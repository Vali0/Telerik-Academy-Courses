using System;

class Worker : Human // Inherit human abstract class
{
    // Fields
    private decimal weekSalary;
    private int workHoursPerDay;

    // Constructors
    public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    // Properties
    public decimal WeekSalary
    {
        get
        {
            return this.weekSalary;
        }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Week salary can't be negative or zero!");
            this.weekSalary = value;
        }
    }

    public int WorkHoursPerDay
    {
        get
        {
            return this.workHoursPerDay;
        }
        set
        {
            if (value <= 0)
                throw new ArgumentException("work hours per day can't be negative or zero!");
            this.workHoursPerDay = value;
        }
    }

    // Methods
    public decimal MoneyPerHour()
    {
        return WeekSalary / (WorkHoursPerDay * 5); // Calculating money per hour
    }
}