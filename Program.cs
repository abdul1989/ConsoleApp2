using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.ConcreteCreator;
using MathsComponent;

namespace ConsoleApp2
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
    class MoneyBack : CreditCardFactory
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }

        protected override ICreditCard MakeProduct()
        {
            throw new NotImplementedException();
        }
    }
    public class Titanium : CreditCardFactory
    {
        public string GetCardType()
        {
            return "Titanium Edge";
        }
        public int GetCreditLimit()
        {
            return 25000;
        }
        public int GetAnnualCharge()
        {
            return 1500;
        }

        protected override ICreditCard MakeProduct()
        {
            throw new NotImplementedException();
        }
    }
    public class Platinum : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum Plus";
        }
        public int GetCreditLimit()
        {
            return 35000;
        }
        public int GetAnnualCharge()
        {
            return 2000;
        }

        protected override ICreditCard MakeProduct()
        {
            ICreditCard objProduct = new Platinum();
            return objProduct;
        }
    }

    public abstract class CreditCardFactory
    {
        protected abstract ICreditCard MakeProduct();
      
        public ICreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            ICreditCard creditCard = new PlatinumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.WriteLine("--------------");
            creditCard = new MoneyBackFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();


        }

    }
}




