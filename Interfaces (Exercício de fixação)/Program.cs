using System;
using Exercicio.Entities;
using Exercicio.Services;
using System.Globalization;

namespace Exercicio 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract Value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            int installmentAmount = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);
            ContractRegistry cr = new ContractRegistry(installmentAmount, new PaymentServices());

            double dividedValue = value / installmentAmount;
            for(int i = 1; i <= installmentAmount; i++)
            {
                DateTime newDate = contract.Date.AddMonths(i);
                double totalValue = cr.SetIOnlinePayment(dividedValue, i);
                Installment installment = new Installment(newDate, totalValue);
                contract.AddInstallments(installment);
            }

            foreach(Installment installments in contract.Installments)
            {
                Console.WriteLine(installments);
            }

            Console.ReadLine();
        }
    }
}
