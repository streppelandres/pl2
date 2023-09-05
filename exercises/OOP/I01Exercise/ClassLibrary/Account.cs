namespace ClassLibrary
{
    public class Account
    {
        private string holder;
        private decimal amount;

        public Account(string holder, decimal amount)
        {
            this.holder = holder;
            this.amount = amount;
        }

        public string Show()
        {
            return $"Account holder: {this.holder}, amount: ${this.amount}";
        }
        
        public void Add(decimal amount)
        {
            if (amount <= 0) return;
            this.amount += amount;
        }

        public void Withdraw(decimal amount)
        {
            this.amount -= amount;
        }
    }
}
