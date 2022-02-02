using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTO
{
    public class ReadFilmeDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo de Titulo é obrigatario")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Campo de Diretor é obrigatorio")]
        public string Diretor { get; set; }
        public string Genero { get; set; }
        [Range(1, 200, ErrorMessage = "Tempo nao permitido")]
        public int Duracao { get; set; }
        public DateTime HoraConsulta { get; set; } 
    }
}
