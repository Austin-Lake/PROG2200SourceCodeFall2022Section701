﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursInYear = 2080;
        public decimal GetAnnualSalary(decimal hourlyWage) => HoursInYear * hourlyWage;
            
        public decimal GetHourlyWage(decimal annualSalary) => annualSalary / HoursInYear;
    }
}
