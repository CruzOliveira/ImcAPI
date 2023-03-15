
using ImcAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImcAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class ImcController : ControllerBase
{

    private static List<Usuario> usuarios = new List<Usuario>();
    private static int id = 0;

    [HttpPost]
    public IActionResult AdicionaUsuario([FromBody] Usuario usuario)
    {
        usuario.Id = id++;
        usuarios.Add(usuario);
        return CreatedAtAction (nameof(RecuperaUsuarioPorId), new { id = usuario.Id }, usuario);
    }

    [HttpGet]
    public IEnumerable<Usuario> RucuperaUsuario([FromQuery] int skip= 0, int take = 30)
    {
        return usuarios.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaUsuarioPorId(int id)
    {
        var usuario = usuarios.FirstOrDefault(usuario => usuario.Id == id);
        if(usuario == null) return NotFound();
        return Ok(usuario);
        

        
    }
}