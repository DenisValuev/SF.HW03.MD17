using SF.HW03.MD17.Models;
using SF.HW03.MD17.Types;

namespace SF.HW03.MD17
{
    /// <summary>
    /// В данном примере отсутствует проверка на введенные данные пользователем, 
    /// так как данная реализация служит рефакторингом кода задания 17.6.4 с принципом открытости/закрытости
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            Console.WriteLine("Введите тип учетной записи");
            account.Type = Console.ReadLine();
            Console.WriteLine("Введите баланс учетной записи:");
            account.Balance = int.Parse(Console.ReadLine());
            switch (account.Type)
            {
                case "Обычный":
                    Calculator.CalculateInterest(new OrdinaryType(), account);
                    Console.WriteLine(account.Interest);
                    break;
                case "Зарплатный":
                    Calculator.CalculateInterest(new SalaryType(), account);
                    break;
                default:
                    Console.WriteLine("Неверно указан тип учетной записи");
                    break;
            }
            Console.WriteLine(account.Interest);
        }
    }
}
