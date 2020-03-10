using System;
using System.Collections.Generic;
using System.Text;

namespace TaxReport.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double annualIncome, int numberOfEmployees)
            : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double total = (NumberOfEmployees <= 10) ?
                (AnnualIncome * .16) :
                (AnnualIncome * .14);
            return total;
        }
    }
}
