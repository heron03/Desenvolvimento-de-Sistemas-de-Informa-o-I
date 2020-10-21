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
            await db.SaveChangesAsync();
            return Ok();
        }
        catch (Exception e)
        {
            return View(e);
        }
    }


    [HttpPut]
    [Route("Update")]
    public async Task<IActionResult> Put([FromBody] Produto produto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        db.Entry(produto).State = EntityState.Modified;
        try
        {
            await db.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            throw (ex);
        }
        return NoContent();
    }

    [HttpGet]
    [Route("GetById")]
    public async Task<IActionResult> Get([FromQuery] string id)
    {
        var produto = await db.Produtos.SingleOrDefaultAsync(x => x.Id == Convert.ToInt32(id));
        return Ok(produto);
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