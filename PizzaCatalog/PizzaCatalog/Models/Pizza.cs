using System.ComponentModel.DataAnnotations;

namespace PizzaCatalog.Controllers
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Ingredients { get; set; }
        public double Price { get; set; }
    }
}
