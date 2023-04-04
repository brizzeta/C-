namespace _03._04.State
{
    internal abstract class State
    {
        protected double interest;
        protected double lowerLimit;
        protected double upperLimit;
        public Account account { get; set; }
        public double balance { get; set; }
        public abstract void Deposit(double amount);
	    public abstract bool Withdraw(double amount);
	    public abstract bool PayInterest();
    }
}
