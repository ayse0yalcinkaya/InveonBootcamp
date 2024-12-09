using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_SOLID
{

    /*
    // subclass
    public class EmailSender
    {
        public void SendEmail(string message)
        {
            Console.WriteLine(message);
        }
    }

    // baseclass
    public class OrderProcessor
    {
        private EmailSender _emailSender;

        public OrderProcessor()
        {
            _emailSender = new EmailSender();
        }

        public void ProcessOrder()
        {
            // sipariş inceleniyor
            Console.WriteLine("Siparişiniz inceleniyor.");

            // Bildirim gönderme
            _emailSender.SendEmail("Siparişiniz hazırlanıyor.");
        }
    }
    */

    // kohezyonu yüksek ama bağımlılığı düşük interfaceler
    public interface INotificationService
    {
        void Notify(string message);
    }

    // email gönderimi
    public class EmailSender : INotificationService
    {
        public void Notify(string message)
        {
            Console.WriteLine($"email: {message}");
        }
    }

    // sms gönderimi
    public class SmsSender : INotificationService
    {
        public void Notify(string message)
        {
            Console.WriteLine($"SMS: {message}");
        }
    }

    // Yüksek seviyeli sınıf
    public class OrderProcessor
    {
        private readonly INotificationService _notificationService;

        public OrderProcessor(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void ProcessOrder()
        {
            // sipariş inceleniyor
            Console.WriteLine("Siparişiniz inceleniyor.");

            // Bildirim gönderme
            _notificationService.Notify("Siparişiniz hazırlanıyor.");

        }
    }



}
