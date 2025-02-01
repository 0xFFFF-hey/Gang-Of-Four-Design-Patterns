using SOLID.SingleResponsibility.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleResponsibility.GoodExample
{
    internal class EmailService
    {
        public void SendConfirmationEmail(Order order)
        {
            // Logic for sending an email
            Console.WriteLine("Email sent to " + order.CustomerEmail);
        }
    }
}
