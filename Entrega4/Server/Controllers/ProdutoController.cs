using Entrega4.Server;
using Microsoft.AspNetCore.Mvc;
using Entrega4.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class ProdutoController : Controller
{
    private readonly AppDbContext db;

    public ProdutoController(AppDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("Lista")]
    public async Task<IActionResult> Get()
    {
        var produtos = await db.Produtos.ToListAsync();
        return Ok(produtos);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] Produto produto)
    {
        try
        {
            var newProduto = new Produto
            {
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                Preco = produto.Preco
            };

            db.Add(newProduto);
            await db.SaveChangesAsync();//INSERT INTO
            return Ok();
        }
        catch (Exception e)
        {
            return View(e);
        }
    }
    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<ActionResult<Produto>> Delete(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var produto = await db.Produtos.FindAsync(id);
        if (produto == null)
        {
            return NotFound();
        }
        db.Produtos.Remove(produto);
        await db.SaveChangesAsync();
        return Ok(produto);
    }

}