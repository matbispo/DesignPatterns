using Microsoft.VisualBasic;
using System;

namespace DesignPatterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Pattern Strategy");

            ITax iss = new ISS();
            ITax icms = new ICMS();

            Budget budget = new Budget(500.0);

            TaxCalculate taxCalculate = new TaxCalculate();

            double taxIssCalculed = taxCalculate.Calculate(budget, iss);
            Console.WriteLine(taxIssCalculed.ToString());

            double taxICMSCalculate = taxCalculate.Calculate(budget, icms);
            Console.WriteLine(taxICMSCalculate.ToString());

            Console.ReadKey();
        }
    }
}
