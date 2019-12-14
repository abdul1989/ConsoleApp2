using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   
   public interface IEmployeeBonus
    {
        decimal CalculateBonus(decimal salary);

    }

   public interface IEmployee
    {
        decimal GetMinimumSalary();

    }



}
