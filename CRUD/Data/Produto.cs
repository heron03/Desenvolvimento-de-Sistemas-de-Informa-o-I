using System;

namespace CRUD.Data
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
    }
}
