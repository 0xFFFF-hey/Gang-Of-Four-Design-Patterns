﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    // "Facade" that encapsulates all the complexities and steps involved in making an order, so clients can make orders without having to know all of the details
    internal class OrderService
    {
        public void Order(OrderRequest orderReq)
        {
            var auth = new Authenticate();

            var inventory = new Inventory();
            foreach (var id in orderReq.ItemIds)
            {
                inventory.CheckInventory(id);
            }

            var payment = new Payment(orderReq.Name, orderReq.CardNumber, orderReq.Amount);
            payment.Pay();

            var orderFulfillment = new OrderFulfillment(inventory);
            orderFulfillment.Fulfill(orderReq.Name, orderReq.Address, orderReq.ItemIds);
        }
    }
}
