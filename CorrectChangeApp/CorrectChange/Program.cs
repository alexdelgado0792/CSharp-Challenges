using System;

namespace CorrectChange
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Total amount to be paid: ");
            var total = Input();

            Console.Write("Enter Customer paid amount: ");
            var paidAmount = Input();

            var factory = new CurrencyFactory();
            var currencies = factory.Currency(CurrencyEnum.Mexico);
            ChangeTools.PrintChange(ChangeTools.CalculateChange(paidAmount, total, currencies));
        }

        private static decimal Input()
        {
            var input = Console.ReadLine();

            decimal amount;
            if (!decimal.TryParse(input, out amount))
            {
                return decimal.Zero;
            }

            return amount;
        }

    }
}
