using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursInYear = 2080;
        public decimal GetAnnualSalary(decimal hourlyWage) 
        {
            if (hourlyWage <= 0)
            {
                throw new InvalidOperationException("Hourly wage must be greater than zero.");
            }
            
            return HoursInYear * hourlyWage;
        }

        public decimal GetHourlyWage(decimal annualSalary) 
        {
            if (annualSalary <= 0)
            {
                throw new InvalidOperationException("Yearly salary must be greater than zero.");
            }

            return annualSalary / HoursInYear;
        }

        public TaxData TaxWithheld(double weeklySalary, int dependents) 
        {
            if (weeklySalary <= 0) 
            {
                throw new InvalidOperationException("Weekly salary must be greater than zero.");
            }

            if (dependents < 0) 
            {
                throw new InvalidOperationException("Number dependents cannot be negative.");
            }

            double ProvincialTaxWithheld = weeklySalary * 0.06;
            double FederalTaxWithheld = weeklySalary * 0.25;
            double DependentDeduction = weeklySalary * dependents * 0.02;
            double TotalWithheld = ProvincialTaxWithheld + FederalTaxWithheld - DependentDeduction;
            double TotalTakeHome = weeklySalary - TotalWithheld;

            return new TaxData(ProvincialTaxWithheld, FederalTaxWithheld, DependentDeduction, TotalWithheld, TotalTakeHome);
        }
    }
}
