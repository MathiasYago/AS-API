using AsAPi.Models;
using System.Collections.Generic;

namespace AsAPI.Repositories
{
    public interface IPedidoRepository
    {
        IEnumerable<pedido> GetAll();
        pedido GetById(int id);
        void Add(pedido pedido);
        void Update(pedido pedido);
        void Delete(int id);
    }
}    
