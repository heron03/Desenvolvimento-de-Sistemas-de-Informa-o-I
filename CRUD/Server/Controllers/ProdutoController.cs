using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using CRUD.Data;

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
        var produto = await db.Produtos.ToListAsync();
        return Ok(produto);
    }

    [HttpGet]
    [Route("GetById")]
    public async Task<IActionResult> Get([FromQuery] string id)
    {
        var produto = await db.Produtos.SingleOrDefaultAsync(x => x.Id == Convert.ToInt32(id));
        return Ok(produto);
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
}