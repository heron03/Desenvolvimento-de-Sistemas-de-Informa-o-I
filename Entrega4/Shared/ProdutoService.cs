using System;
using System.Linq;
using System.Threading.Tasks;

namespace Entrega4.Data
{
    public class ProdutoService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<Produto[]> GetProdutoAsync(DateTime startDate)
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Produto
            {
                Id = 1,
                Nome = "A",
                Descricao = "A",
                Preco = 10,
                Created = startDate
            }).ToArray());
        }
    }
}
