namespace Opgaver_4
{
    public class BankAccount
    {
        
        public BankAccount (decimal balance) 
        {
            if (balance >= 0) {
                Balance = balance;
            } else {
                throw new InsufficientFundsException();
            }
        }

        public decimal Balance { get; private set; }

        public void Deposit (decimal depositAmount) 
        {
            Balance += depositAmount;
        }

        public void Withdrawl (decimal amount) {
            if (Balance >= amount) {
                Balance -= amount;
            } else {
                throw new InsufficientFundsException();
            }
        }
    }

}

