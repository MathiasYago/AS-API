using AsAPi.Models;
using System.Collections.Generic;

namespace AsAPI.Repositories
{
    public interface IFornecedorRepository
    {
        IEnumerable<Fornecedor> GetAll();
        Fornecedor GetById(int id);
        void Add(Fornecedor fornecedor);
        void Update (Fornecedor fornecedor);
        void Delete(int id);
    }
}    
