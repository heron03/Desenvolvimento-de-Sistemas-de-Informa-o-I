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
}