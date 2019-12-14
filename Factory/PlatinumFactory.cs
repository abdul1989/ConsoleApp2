using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Factory
{
    public class PlatinumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Platinum();
            return product;
        }
    }
}
