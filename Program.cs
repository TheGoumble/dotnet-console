// test bank progam
Console.WriteLine("Welcome to Bank Boca Code ");

BankAccount account = new BankAccount();
account.AccountNumber = "12345";

account.MakeDeposit(100);

BankAccount account2 = new SavingAccount(500);

try
{
    decimal newBalance = account2.MakeDepositGetBalance(-1);
}
catch (Exception ex)
{
    Console.WriteLine($" we got an error when running MakeDepositGetBalance(-1)");
}

Console.WriteLine($"The blance of account is {account.Balance}");
Console.WriteLine($"The blance of account is {account.AccountNumber}");

Console.WriteLine($"The blance of account2 is {account2.Balance}");