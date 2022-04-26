using Microsoft.AspNetCore.Mvc;
using OrderHandler.Data;
using OrderHandler.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderHandler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderContext _context;

        public OrderController(OrderContext _context)
        {
            this._context = _context;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _context.Orders.ToList();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return _context.Orders.SingleOrDefault(c => c.Id == id);
        }

        // POST api/<OrderController>
        [HttpPost]
        public void Post(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

    }
}
