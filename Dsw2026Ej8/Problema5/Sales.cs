using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema5
{    public class Sale
{    public decimal Subtotal {get; set;} = 1000m;
     public virtual decimal CalculateTotal()
            {   return Subtotal;        }
}
     public class RetailSale : Sale
    {
        public override decimal CalculateTotal()
        {      return Subtotal;      }
    }
    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        {       return Subtotal - (Subtotal * 0.10m);
        }
    }
}