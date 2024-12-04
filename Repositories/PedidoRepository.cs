
using AsAPI.Data;
using System.Collections.Generic;
using System.Linq;
using AsAPi.Models;

namespace AsAPI.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _context;
        public PedidoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<pedido> GetAll() => _context.Pedidos.ToList();


        public pedido GetById(int id) => _context.Pedidos.Find(id);

        public void Add(pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
        }

        public void Update(pedido pedido)
        {
            _context.Pedidos.Update(pedido);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var pedido = GetById(id); 
            if (pedido != null)
            {
                _context.Pedidos.Remove(pedido);
                _context.SaveChanges();
            }
        }
    }
}
