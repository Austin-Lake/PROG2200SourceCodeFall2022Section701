using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace SalaryCalculatorTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnnualSalaryCalculator()
        {
            SalaryCalculator sc = new SalaryCalculator();

            decimal annualSalary = sc.GetAnnualSalary(50);

            Assert.AreEqual(104000, annualSalary);
        }
    }
}
