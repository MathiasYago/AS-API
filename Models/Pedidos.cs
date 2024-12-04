using System.Data;

namespace AsAPi.Models
{
    public class pedido
    {
        public int Id { get; set; }
    public int Nome { get; set; }
    public DateTime Data { get; set; }

    public Decimal ValorTotal { get; set; }

    public string Status { get; set; }

    public string Descricao { get; set;}
    }
}

