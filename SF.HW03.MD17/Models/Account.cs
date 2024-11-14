using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.HW03.MD17.Models
{
    public class Account
    {
        //Тип учетной записи
        public string Type { get; set; }
        //Баланс учетной записи
        public double Balance { get; set; }
        //Процентная ставка
        public double Interest { get; set; }
    }
}
