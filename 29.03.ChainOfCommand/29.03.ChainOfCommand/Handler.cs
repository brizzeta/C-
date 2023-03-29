using System;

namespace _29._03.ChainOfCommand
{
    internal abstract class PaymentHandler
    {
        public PaymentHandler Successor { get; set; }
        public abstract void Handle(Receiver receiver);
    }

    // банковский перевод
    class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
	    {
		    if (receiver.BankTransfer)
		    	Console.WriteLine("Bank transfer");
		    else if (Successor != null)
		    	Successor.Handle(receiver);
        }
    };

    // переводы с помощью системы денежных переводов типа WesternUnion или Unistream
    class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer)
                Console.WriteLine("Transfer through money transfer systems");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    };

    // система онлайн-платежей PayPal
    class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer)
                Console.WriteLine("Transfer via paypal");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    };
}
