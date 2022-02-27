using Microsoft.AspNetCore.Mvc;
using UsuarioApi.Data.Dtos;

namespace UsuarioApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CadastroController
    {
        [HttpPost]
        public string CadastraUsuario(CreateUsuarioDto createDto)
        {
            //Todo chamar Service
            return "ok";
        }
    }
}
