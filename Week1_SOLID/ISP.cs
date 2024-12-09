using System;


namespace Week1_SOLID
{

    //public interface IISP
    //{
    //    void AddProduct(string productName);
    //    void ProcessPayment(string paymentMethod);
    //    void TrackOrder(int orderId);
    //}

    //// Bu arayüzü implement eden sınıflar
    //public class Admin : IISP
    //{
    //    public void AddProduct(string productName)
    //    {
    //        Console.WriteLine("Ürün Ekler");
    //    }

    //    public void ProcessPayment(string paymentMethod)
    //    {
    //        Console.WriteLine("ödeme Yapmaz");
    //    }

    //    public void TrackOrder(int orderId)
    //    {
    //        Console.WriteLine("Siparişini takip etmez");
    //    }
    //}

    //public class Customer : IISP
    //{
    //    public void AddProduct(string productName)
    //    {
    //        Console.WriteLine("Ürün ekleyemez");
    //    }

    //    public void ProcessPayment(string paymentMethod)
    //    {
    //        Console.WriteLine("Ödeme yapar");
    //    }

    //    public void TrackOrder(int orderId)
    //    {
    //        Console.WriteLine("Siparişini takip eder.");
    //    }
    //}
        public interface IProductOperations
        {
            void AddProduct(string productName);
        }

        public interface IPaymentOperations
        {
            void ProcessPayment(string paymentMethod);
        }

        public interface IOrderOperations
        {
            void TrackOrder(int orderId);
        }

        public class Admin : IProductOperations
        {
            public void AddProduct(string productName)
            {
                Console.WriteLine("Ürün Ekler");
            }
        }

        public class Customer : IPaymentOperations, IOrderOperations
        {
            public void ProcessPayment(string paymentMethod)
            {
                Console.WriteLine("Ödeme yapar");
            }

            public void TrackOrder(int orderId)
            {
                Console.WriteLine("Siparişini takip eder.");
            }
        }
 }


