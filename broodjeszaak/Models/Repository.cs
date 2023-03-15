namespace broodjeszaak.Models
{
    public class Repository
    {
        private static List<Order> order = new();
        public static IEnumerable<Order> Orders => order;

        public void AddOrder(Order order)
        {
            Repository.order.Add(order);
        }
    }
}
