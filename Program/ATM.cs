public class ATM(decimal initialBalance)
{
    private decimal balance = initialBalance;

    public void CheckBalance() {
        Console.WriteLine($"Your current balance is: {balance:C}");
    }
    public void DepositMoney(decimal amount) {
        if (amount > 0) {
            balance += amount;
            Console.WriteLine($"You have successfully deposited {amount:C}. Your new balance is: {balance:C}");
        } else {
            Console.WriteLine("Deposit amount must be greater than zero");
        }
    }
    public void WithdrawMoney(decimal amount) {
        if (amount > 0){
            if (amount <= balance) {
                balance-= amount;
                Console.WriteLine($"You have withdrawn {amount:C}. New balance: {balance:C}");
            } else {
                Console.WriteLine("Insufficient funds");
            }
        } else {
            Console.WriteLine("Withdrawal amount must be greater than zero");
        }
    }
}