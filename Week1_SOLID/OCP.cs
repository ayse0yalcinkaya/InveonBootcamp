namespace Week1_SOLID
{
    /*
      public class OCP
    {
        public double Amount { get; set; }
        public string Type { get; set; }

        public double CalculateDiscount()
        {
            double discount = 0;
            if (Type == "Cash")
            {
                discount = Amount * 0.1; 
            }
            else if (Type == "Credit")
            {
                discount = Amount * 0.05; 
            }
            return discount;
        }
    }
     */


    public interface IOCP
    {
        double CalculateDiscount(Invoice invoice);
    }

    public class CashDiscountStrategy : IOCP
    {
        public double CalculateDiscount(Invoice invoice)
        {
            return invoice.Amount * 0.1; 
        }
    }

    public class CreditDiscountStrategy : IOCP
    {
        public double CalculateDiscount(Invoice invoice)
        {
            return invoice.Amount * 0.05; 
        }
    }

    public class PayPalDiscountStrategy : IOCP
    {
        public double CalculateDiscount(Invoice invoice)
        {
            return invoice.Amount * 0.07; 
        }
    }

    public class Invoice
    {
        public double Amount { get; set; }
        public IOCP DiscountStrategy { get; set; }

        public double CalculateDiscount()
        {
            return DiscountStrategy.CalculateDiscount(this);
        }
    }
}
