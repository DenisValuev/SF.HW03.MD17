using SF.HW03.MD17.Models;
using SF.HW03.MD17.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.HW03.MD17
{
    public static class Calculator
    {
        public static void CalculateInterest(ICalculatorType calculatorType, Account account)
        {
            calculatorType.Calculate(account);
        }
    }
}
