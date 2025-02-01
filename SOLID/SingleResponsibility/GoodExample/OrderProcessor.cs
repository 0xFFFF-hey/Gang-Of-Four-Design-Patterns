using SOLID.SingleResponsibility.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleResponsibility.GoodExample
{
    internal class OrderProcessor
    {
        private readonly EmailService _emailService;

        public OrderProcessor(EmailService emailService)
        {
            _emailService = emailService;
        }

        public void ProcessOrder(Order order)
        {
            // Process the order (e.g., payment, inventory)
            Console.WriteLine("Order processed");

            // Send confirmation email (delegated to the EmailService)
            _emailService.SendConfirmationEmail(order);
        }
    }
}
