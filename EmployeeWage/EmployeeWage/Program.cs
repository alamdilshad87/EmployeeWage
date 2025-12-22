using System;
using System.Collections.Generic;

public interface IEmployeeWageManager
{
    void AddCompany(string company, int ratePerHour, int workingDays, int maxHours);
    void ComputeAllWages();
    int GetTotalWage(string company);
}

public class EmployeeWageManager : IEmployeeWageManager
{
    private List<EmployeeWage> companyList;

    public EmployeeWageManager()
    {
        companyList = new List<EmployeeWage>();
    }

    public void AddCompany(string company, int ratePerHour, int workingDays, int maxHours)
    {
        EmployeeWage empWage = new EmployeeWage(company, ratePerHour, workingDays, maxHours);
        companyList.Add(empWage);
    }

    public void ComputeAllWages()
    {
        foreach (EmployeeWage company in companyList)
        {
            company.computeEmpWage();
        }
    }

    // UC: Get Total Wage when queried by Company
    public int GetTotalWage(string companyName)
    {
        foreach (EmployeeWage company in companyList)
        {
            if (company.getCompany()
                       .Equals(companyName, StringComparison.OrdinalIgnoreCase))
            {
                return company.getTotalEmpWage();
            }
        }
        return 0;
    }
}

public class EmployeeWage
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;

    private string company;
    private int empRatePerHour;
    private int numOfWorkingDays;
    private int maxHoursPerMonth;
    private int totalEmpWage;

    private List<int> dailyWageList;
    private static Random random = new Random();

    public EmployeeWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
    {
        this.company = company;
        this.empRatePerHour = empRatePerHour;
        this.numOfWorkingDays = numOfWorkingDays;
        this.maxHoursPerMonth = maxHoursPerMonth;
        this.dailyWageList = new List<int>();
    }

    public string getCompany()
    {
        return this.company;
    }

    public int getTotalEmpWage()
    {
        return this.totalEmpWage;
    }

    public void computeEmpWage()
    {
        int empHrs = 0;
        int totalEmpHrs = 0;
        int totalWorkingDays = 0;

        dailyWageList.Clear();

        while (totalEmpHrs <= this.maxHoursPerMonth &&
               totalWorkingDays < this.numOfWorkingDays)
        {
            totalWorkingDays++;

            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;

                case IS_FULL_TIME:
                    empHrs = 8;
                    break;

                default:
                    empHrs = 0;
                    break;
            }

            int dailyWage = empHrs * empRatePerHour;
            dailyWageList.Add(dailyWage);

            totalEmpHrs += empHrs;
        }

        totalEmpWage = totalEmpHrs * empRatePerHour;

        Console.WriteLine("Daily Wages for company : " + company);
        foreach (int wage in dailyWageList)
        {
            Console.WriteLine(wage);
        }

        Console.WriteLine("Total Emp Wage for company : " + company + " is : " + totalEmpWage);
    }

    public string toString()
    {
        return "Total Emp Wage for company : " + this.company + " is : " + this.totalEmpWage;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        IEmployeeWageManager manager = new EmployeeWageManager();

        manager.AddCompany("DMart", 20, 2, 10);
        manager.AddCompany("Reliance", 10, 4, 20);
        manager.AddCompany("TCS", 25, 22, 100);

        manager.ComputeAllWages();

        Console.WriteLine("Queried DMart Wage : " + manager.GetTotalWage("DMart"));
        Console.WriteLine("Queried Reliance Wage : " + manager.GetTotalWage("Reliance"));
        Console.WriteLine("Queried TCS Wage : " + manager.GetTotalWage("tcs"));
    }
}
