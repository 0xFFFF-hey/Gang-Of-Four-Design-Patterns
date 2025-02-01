using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleResponsibility.BadExample
{
    internal class OrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            // Process the order (e.g., payment, inventory)
            Console.WriteLine("Order processed");

            // Send confirmation email
            SendConfirmationEmail(order);
        }

        private void SendConfirmationEmail(Order order)
        {
            // Logic for sending an email
            Console.WriteLine("Email sent to " + order.CustomerEmail);
        }
    }
}
