using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class BankAccount
    {
        private double _balance;

        public BankAccount(double initialBalance = 0)
        {
            _balance = initialBalance;
        }

        public double GetBalance()
        {
            return _balance;
        }

        public void Deposit(double sum)
        {
            if (sum > 0)
            {
                _balance += sum;
                Console.WriteLine($"Счет пополнен на {sum}");
            }
            else
                Console.WriteLine("Счет не пополнен");
        }

        public void Withdraw(double sum)
        {
            if (sum > 0 && sum <= _balance)
            {
                _balance -= sum;
                Console.WriteLine($"Со счета снято {sum}");
            }
            else
                Console.WriteLine("Деньги не сняты со счета");
        }
    }
}
