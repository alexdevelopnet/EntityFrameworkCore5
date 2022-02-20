using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private IBaseService<Filme> _baseUserService;
        public FilmeController(IBaseService<Filme> baseUserService)
        {
            this._baseUserService = baseUserService;
        }

        //private static List<Filme> filmes = new List<Filme>();
        //private static int id = 1;

        [HttpPost]
        public IActionResult AdicionarFilme([FromBody] Filme filme)
        {
            if (filme ==null)
            {
                return NotFound();
            }
            return Execute(() => _baseUserService.Add(filme));
            
           // return CreatedAtAction(nameof(RecuperarFilmesId), new { Îd = filme.Id }, filme);
        }

        [HttpGet]
        public IActionResult RecuperarFilmes()
        {
            IEnumerable<Filme> filmes = _baseUserService.Get();
            return Ok(filmes);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarFilmesId(int id)
        {
            if (id == 0)
                return NotFound();

            return Execute(() => _baseUserService.GetById(id));
        }

        private IActionResult Execute(Func<object> func)
        {
            try
            {
                var result = func();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }

}
