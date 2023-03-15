using System.ComponentModel.DataAnnotations;
namespace broodjeszaak.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        public Custommers Custommer { get; set; }

        public Broodjes broodje { get; set; }
    }
}