using task1;

BankAccount account = new BankAccount();
account.Deposit(50);
account.Withdraw(30);
account.Withdraw(150);
Console.WriteLine($"Финальный баланс: {account.GetBalance()}");