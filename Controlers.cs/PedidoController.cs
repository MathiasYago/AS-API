using Microsoft.AspNetCore.Mvc;
using AsAPI.Repositories;
using AsAPi.Models;

namespace OrderSupplierAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoRepository _repository;

        public PedidoController(IPedidoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_repository.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var pedido = _repository.GetById(id);
            return pedido == null ? NotFound() : Ok(pedido);
        }

        [HttpPost]
        public IActionResult Add(pedido pedido)
        {
            _repository.Add(pedido);
            return CreatedAtAction(nameof(GetById), new { id = pedido.Id }, pedido);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, pedido pedido)
        {
            if (id != pedido.Id) return BadRequest();
            _repository.Update(pedido);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return NoContent();
        }
    }
}