using System.ComponentModel.DataAnnotations;

namespace UsuarioApi.Data.Dtos
{
    public class CreateUsuarioDto
    {
        [Required]
        public int MyProperty { get; set; }
        [Required]
        public int Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public int RePassword { get; set; }
    }
}
