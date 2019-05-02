using System;
using System.Collections.Generic;

namespace CorrectChange
{
    public class CurrencyFactory
    {
        public IList<decimal> Currency(CurrencyEnum currency)
        {
            switch (currency)
            {
                case CurrencyEnum.Mexico:
                    return MexicoCurrency();

                case CurrencyEnum.Usa:
                    return UsaCurrency();

                default:
                    throw new Exception($"Not valid currency {currency}") ;
            }
        }

        #region Currencies

        private IList<decimal> UsaCurrency()
        {
            throw new NotImplementedException();
        }

        private IList<decimal> MexicoCurrency()
        {
            return new List<decimal>(){
                {1000},
                {500},
                {200},
                {100},
                {50},
                {20},
                {10},
                {5},
                {2},
                {1},
                {0.50m},
            };
        }

        #endregion

    }
}