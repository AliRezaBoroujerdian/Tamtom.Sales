using System;
using System.Collections.Generic;
using System.Text;

namespace Tamtom.Sales.Currency
{
    public class CurrencyModel
    {
        public int CurrencyID { get; set; }
        public string Symbol { get; set; }
        public string CurrencyCode { get; set; }
        public bool? CurrencyIsActive { get; set; }
        public string Name { get; set; }
        public bool? LanguageIsActive { get; set; }
    }
}
