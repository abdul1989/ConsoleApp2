using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.ConcreteCreator
{
    public class TitaniumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Titanium();
            return product;
        }
    }
}
