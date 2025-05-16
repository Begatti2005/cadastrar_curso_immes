using Microsoft.AspNetCore.Mvc;
using ImmesAPI.Domain;
using ImmesAPI.Data;
using ImmesAPI.DTOs;

namespace ImmesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        [HttpGet("listar")]
        public IActionResult ListarCurso()
        {
            using var context = new ImmesContext();
            var cursos = context.CursoSet.ToList(); //select *...
            return Ok(cursos);
        }

        [HttpGet("obter/{id:int}")]
        public IActionResult Obter(int id)
        {
            using var context = new ImmesContext();
            var curso = context.CursoSet.Find(id);
            return Ok(curso);
        }

        [HttpPost("adicionar")]
        public IActionResult Adicionar(Curso curso)
        {
            using var context = new ImmesContext();
            context.CursoSet.Add(curso);
            context.SaveChanges();

            return Created("Created", new BaseResponse("Curso Adicionado com Sucesso."));
        }

        [HttpPut("atualizar")]
        public IActionResult Atualizar(Curso curso)
        {
            using var context = new ImmesContext();
            context.CursoSet.Update(curso);
            context.SaveChanges();

            return Ok(new BaseResponse("Curso Atualizado com Sucesso."));
        }

        [HttpDelete("remover/{id:int}")]
        public IActionResult Remover(int id)
        {
            using var context = new ImmesContext();
            var curso = context.CursoSet.Find(id);
            
            if (curso is null)
                return NoContent();
            
            context.CursoSet.Remove(curso);
            context.SaveChanges();

            return Ok(new BaseResponse("Curso Removido com Sucesso."));
        }
    }
}
