using System;
using System.Collections.Generic;
using TaxReport.Entities;

namespace TaxReport
{
    class Print
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxReport = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int nTaxPayer = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nTaxPayer; i++)
            {
                Console.WriteLine($"Tax payer #{i} details:");
                Console.Write("Individual or company (i/c)? ");
                char answer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine());
                if (answer.Equals('i'))
                {
                    Console.Write("Health expenditures: ");
                    double healthExpends = double.Parse(Console.ReadLine());
                    taxReport.Add(new Individual(name, annualIncome, healthExpends));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int nEmployees = int.Parse(Console.ReadLine());
                    taxReport.Add(new Company(name, annualIncome, nEmployees));
                }
            }

            Console.WriteLine("\nTAXES PAID: ");
            double totalTax = 0;
            foreach (TaxPayer taxPayer in taxReport)
            {
                totalTax += taxPayer.Tax();
                Console.WriteLine(taxPayer);
            }
            Console.WriteLine($"\n\nTOTAL TAXES: " +
                $"£{totalTax.ToString("F2")}");
        }
    }
}
