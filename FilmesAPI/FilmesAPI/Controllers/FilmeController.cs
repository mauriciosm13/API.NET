using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.DTO;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class FilmeController : ControllerBase
    {
        private FilmeContext _context;
        private IMapper _mapper;

        public FilmeController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult AdicionarFilme([FromBody] CreateFilmeDTO filmeDto)
        {
            Filme filme = _mapper.Map<Filme>(filmeDto);
            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaFilmePorId), new { Id = filme.Id }, filme);
        }
        [HttpGet]
        public IEnumerable<Filme> RecuperarFilme()
        {
            return _context.Filmes;
        }
        [HttpGet("{id}")]
        public IActionResult RecuperaFilmePorId(int id)
        {
            Filme filme = _context.Filmes.FirstOrDefault(filmes => filmes.Id == id);
            if (filme != null)
            {
                ReadFilmeDTO filmeNovo = _mapper.Map<ReadFilmeDTO>(filme);
                return Ok(filmeNovo);
            }
            return NotFound();
        }
        [HttpPut("{id}")]
        public IActionResult AtualizarFilme(int id, [FromBody] UpdateFilmeDTO FilmeBody)
        {
            Filme filme = _context.Filmes.FirstOrDefault(filmes => filmes.Id == id);
            if (filme == null)
            {
                return NotFound();
            }
            else
            {
                _mapper.Map(FilmeBody, filme);
                _context.SaveChanges();
                return NoContent();
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Filme filme = _context.Filmes.FirstOrDefault(filmes => filmes.Id == id);
            if (filme == null)
            {
                return NotFound();
            }
            else
            {
                _context.Remove(filme);
                _context.SaveChanges();
                return NoContent();
            }
        }
    }
}
