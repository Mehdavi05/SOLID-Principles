using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//5. Dependency Inversion Principle (DIP)
//Principle: High - level modules should not depend on low-level modules. Both should depend on abstractions.
//Abstractions should not depend on details. Details should depend on abstractions.

namespace Solid
{
    // Abstraction for message services
    public interface IMessageService
    {
        void SendMessage(string message);
    }

    // Low-level module: Email service
    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Sending email: " + message);
        }
    }

    // Low-level module: SMS service
    public class SmsService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Sending SMS: " + message);
        }
    }

    // High-level module: Notification
    public class Notification
    {
        private readonly IMessageService _messageService;

        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Notify(string message)
        {
            _messageService.SendMessage(message);
        }
    }
}
