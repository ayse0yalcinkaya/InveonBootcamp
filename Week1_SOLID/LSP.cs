using System;

namespace Week1_SOLID
{
    //public class ILSP
    //{
    //    public virtual void ProcessPayment(double amount)
    //    {
    //        Console.WriteLine("Ödeme alınıyor...");
    //    }
    //}

    //public class CreditCardPaymentProcessor : ILSP
    //{
    //    public override void ProcessPayment(double amount)
    //    {
    //        Console.WriteLine($"Kredi kartı ile {amount} TL ödeme tamamlandı");
    //    }
    //}

    //public class CashPaymentProcessor : ILSP
    //{
    //    public override void ProcessPayment(double amount)
    //    {
    //        Console.WriteLine($"Bu ürün için nakit ödeme seçeneği yoktur");
    //    }
    //}

    public interface ILSP
    {
        void ProcessPayment(double amount);
    }

    public class CreditCardPaymentProcessor : ILSP
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Kredi kartı ile {amount} TL ödeme tamamlandı");
        }
    }

    public class CashPaymentProcessor : ILSP
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Nakit ödeme ile {amount} TL ödeme yapılabilir.");
        }
    }

    public class PaymentService
    {
        private readonly ILSP _paymentProcessor;

        public PaymentService(ILSP paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void Process(double amount)
        {
            _paymentProcessor.ProcessPayment(amount);
        }
    }
}

