﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class TaxData
    {
        public double ProvincialTaxWithheld;
        public double FederalTaxWithheld;
        public double DependentDeduction;
        public double TotalWithheld;
        public double TotalTakeHome;

        public TaxData(double provTax, double fedTax, double dependDeduct,
            double totalWithheld, double totalTakeHome) 
        {
            this.ProvincialTaxWithheld = provTax;
            this.FederalTaxWithheld = fedTax;
            this.DependentDeduction = dependDeduct;
            this.TotalWithheld = totalWithheld;
            this.TotalTakeHome = totalTakeHome;
        }
    }
}
