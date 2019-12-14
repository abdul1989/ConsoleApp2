using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Factory
{
    public class TitaniumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Titanium();
            return product;
        }
    }
}
