using DesignPatterns.Creational.FactoryMethod.BadExample.BackendFramework;

namespace DesignPatterns.Creational.FactoryMethod.BadExample
{
    internal class OrdersController : Controller
    {
        public void ListOrders()
        {
            // Simulate fetching users previous orders from db
            var orders = new Dictionary<string, object>{
                {"Red socks", "$12.98"},
                {"Black socks", "$12.98"},
                {"Pink T-shirt", "29.00"}
            };

            Render("orders.php", orders);
        }

        public void GetOrder(int id)
        {
            // Simulate getting single order by id from db
            var order = new Dictionary<string, object>{
                {"Red Socks", "$12.98"}
            };

            Render("order.php", order);
        }
    }
}
