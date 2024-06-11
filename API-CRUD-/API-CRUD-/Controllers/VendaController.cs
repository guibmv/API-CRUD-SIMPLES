using API_CRUD_.DBContext;
using API_CRUD_.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_CRUD_.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController
    {
        private readonly AppDbContext dbContext;

        public VendaController(AppDbContext _context)
        {
            dbContext = _context;
        }

        [HttpGet()]
        public IEnumerable<Venda> Get()
        {
            return dbContext.Venda.ToList();
        }

        public static List<Venda> produto = new List<Venda>();

        [HttpPost()]
        public Venda Post([FromBody] Venda venda)
        {
            dbContext.Venda.Add(venda);
            dbContext.SaveChanges();

            return venda;
        }
    }
}
