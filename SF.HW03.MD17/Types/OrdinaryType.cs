using SF.HW03.MD17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.HW03.MD17.Types
{
    internal class OrdinaryType : ICalculatorType
    {
        public void Calculate(Account account)
        {
            //Расчет процентной ставки обычного аккаунта по правилам банка
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
            {
                account.Interest -= account.Balance * 0.2;
            }
            if (account.Balance >= 1000)
            {
                account.Interest -= account.Balance * 0.4;
            }
        }
    }
}
