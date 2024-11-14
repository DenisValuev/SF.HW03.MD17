using SF.HW03.MD17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.HW03.MD17.Types
{
    internal class SalaryType : ICalculatorType
    {
        public void Calculate(Account account)
        {
            //Расчет процентной ставки зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;
        }
    }
}
