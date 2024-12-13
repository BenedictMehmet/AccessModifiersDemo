namespace AccessModifiersDemo
{
    public class PrivateAccount
    {
        private decimal balance; // Private Variable für den Kontostand

        public PrivateAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void AddBalance(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }
    }
}
