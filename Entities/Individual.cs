using System;
using System.Collections.Generic;
using System.Text;

namespace TaxReport.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double annualIncome, double healthExpenditures)
            : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double total = (AnnualIncome < 20000) ?
                (AnnualIncome * .15) - (HealthExpenditures * .50) :
                (AnnualIncome * .25) - (HealthExpenditures * .50);
            return total;
        }

        public override string ToString()
        {
            return $"{Name}: £{Tax().ToString("F2")}";
        }
    }
}
