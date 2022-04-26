using System.ComponentModel.DataAnnotations;

namespace OrderHandler.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string PizzaId { get; set; }
        public double TotalPrice { get; set; }
     
    }
}
