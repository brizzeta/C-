namespace _29._03.ChainOfCommand
{
    internal class Program
    {
        static void Request(PaymentHandler h, Receiver receiver)
        {
            h.Handle(receiver);
        }
        static void Main(string[] args)
        {
            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHandler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();

            bankPaymentHandler.Successor = paypalPaymentHandler;
            paypalPaymentHandler.Successor = moneyPaymentHandler;

            Receiver receiver = new Receiver(false, false, true);
            Request(bankPaymentHandler, receiver);

            receiver = new Receiver(false, true, false);
            Request(bankPaymentHandler, receiver);

            receiver = new Receiver(true, false, false);
            Request(bankPaymentHandler, receiver);
        }
    }
}
