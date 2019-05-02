using System;
using System.Collections.Generic;

namespace CorrectChange
{
    public class ChangeTools
    {
        public static IDictionary<decimal, int> CalculateChange(decimal paidAmount, decimal total, IList<decimal> currencies)
        {
            if (paidAmount < total)
            {
                throw new Exception("Not enough to pay.");
            }

            var remaining = paidAmount - total;

            Console.WriteLine($"\nReturn {remaining}"); 

            var result = new Dictionary<decimal, int>();
            foreach (var currency in currencies)
            {
                if (remaining == decimal.Zero)
                {
                    break;
                }

                var qty = (int)(remaining / currency);
                if (qty != 0)
                {
                    remaining -= (currency * qty);
                    result.Add(currency, qty);
                }
            }

            if (remaining > decimal.Zero)
            {
                Console.WriteLine("Money remaining without change: ${0}", remaining);
            }

            return result;
        }

        public static void PrintChange(IDictionary<decimal, int> currencies)
        {
            Console.WriteLine("\n-----Customer Change-----");

            foreach (var currency in currencies)
            {
                Console.WriteLine("{0:N2} -> {1}", currency.Key, currency.Value);
            }

            Console.WriteLine("-----THANKS for your purchase!!!-----");
        }
    }
}