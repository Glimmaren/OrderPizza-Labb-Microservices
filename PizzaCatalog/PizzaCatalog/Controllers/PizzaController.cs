using System.Diagnostics.Eventing.Reader;
using Microsoft.AspNetCore.Mvc;
using PizzaCatalog.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzaCatalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly CatalogContext _context;

        public PizzaController(CatalogContext context)
        {
            _context = context;
        }

        // GET: api/<PizzaController>
        [HttpGet]
        public IEnumerable<Pizza> GetAllPizzas()
        {
            return _context.Pizzas.ToList();
        }

        // GET api/<PizzaController>/5
        [HttpGet("{id}")]
        public Pizza GetPizzaById(int id)
        {

                return _context.Pizzas.SingleOrDefault(c => c.Id == id);
        }

        // POST api/<PizzaController>
        [HttpPost()]
        public void AddPizza(Pizza pizza)
        {
           
                _context.Pizzas.Add(pizza);
                _context.SaveChanges();
            
        }

    }
}
