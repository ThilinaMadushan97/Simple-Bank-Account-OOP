using OopClasses;

BankAccount account1 = new BankAccount("Thilina Madushan", 5000);
BankAccount account2 = new BankAccount("Piyal Siriwardhana", 10000);


Console.WriteLine($"This account owner is {account1.Owner} and account number is {account1.Number}");
Console.WriteLine($"This account owner is {account2.Owner} and account number is {account2.Number}");
