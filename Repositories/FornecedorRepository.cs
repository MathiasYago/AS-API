using AsAPI.Data;
using System.Collections.Generic;
using System.Linq;
using AsAPi.Models;

namespace AsAPI.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly AppDbContext _context;
        public FornecedorRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Fornecedor> GetAll() => _context.Fornecedores.ToList();


        public Fornecedor GetById(int id) => _context.Fornecedores.Find(id);

        public void Add(Fornecedor fornecedor)
        {
            _context.Fornecedores.Add(fornecedor);
            _context.SaveChanges();
        }

        public void Update(Fornecedor fornecedor)
        {
            _context.Fornecedores.Update(fornecedor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var fornecedor = GetById(id); 
            if (fornecedor != null)
            {
                _context.Fornecedores.Remove(fornecedor);
                _context.SaveChanges();
            }
        }
    }
}