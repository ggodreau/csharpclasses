using System;

namespace Polymorphism
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("sending sms meow");
        }
    }
}
