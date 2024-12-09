using System;

namespace Week1_SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SRP:");
            SRP employee = new SRP { Name = "Ayşe", Department = "IT" };

            EmployeeRepository repository = new EmployeeRepository();
            repository.SaveEmployee(employee);

            EmployeePrinter printer = new EmployeePrinter();
            printer.PrintEmployeeDetails(employee);



            Console.WriteLine();  
            Console.WriteLine("OCP:");
            Invoice invoice = new Invoice { Amount = 1000 };

            invoice.DiscountStrategy = new CashDiscountStrategy();
            Console.WriteLine($"Nakit: {invoice.CalculateDiscount()}");

            invoice.DiscountStrategy = new CreditDiscountStrategy();
            Console.WriteLine($"Kredi Kartı: {invoice.CalculateDiscount()}");

            invoice.DiscountStrategy = new PayPalDiscountStrategy();
            Console.WriteLine($"PayPal: {invoice.CalculateDiscount()}");



            Console.WriteLine();  
            Console.WriteLine("LSP: ");
            ILSP creditCardPayment = new CreditCardPaymentProcessor();
            PaymentService creditCardPaymentService = new PaymentService(creditCardPayment);
            creditCardPaymentService.Process(100.50);  

       
            ILSP cashPayment = new CashPaymentProcessor();
            PaymentService cashPaymentService = new PaymentService(cashPayment);
            cashPaymentService.Process(50.00);  



            Console.WriteLine();  
            Console.WriteLine("ISP:");
            IProductOperations adminProductOperations = new Admin();
            adminProductOperations.AddProduct("Yeni Ürün");

            IPaymentOperations customerPaymentOperations = new Customer();
            IOrderOperations customerOrderOperations = new Customer();

            customerPaymentOperations.ProcessPayment("Kredi Kartı");
            customerOrderOperations.TrackOrder(12345);


            Console.WriteLine();  // Boş bir satır
            Console.WriteLine("DIP:");
            // Email bildirim sistemiyle çalışmak
            INotificationService emailNotification = new EmailSender();
            OrderProcessor orderWithEmail = new OrderProcessor(emailNotification);
            orderWithEmail.ProcessOrder();

            // SMS bildirim sistemiyle çalışmak
            INotificationService smsNotification = new SmsSender();
            OrderProcessor orderWithSms = new OrderProcessor(smsNotification);
            orderWithSms.ProcessOrder();
        }
    }
}
