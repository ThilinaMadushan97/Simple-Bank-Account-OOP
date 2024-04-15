using OopClasses;

BankAccount account1 = new BankAccount("Thilina Madushan", 5000);

account1.MakeDeposit(12000, DateTime.Now, "Fund");

account1.MakeWithdrowal(2000, DateTime.Now, "Car service");

Console.WriteLine("Your bank account summery is");
Console.WriteLine("------------------------------");
Console.WriteLine(account1.GetAccountHistory());

Console.WriteLine($"Your current balence is {account1.Balance}");