using AlmoxarifadoSRN.DTO;
using AlmoxarifadoSRN.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoSRN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly List<Categoria> _categoraia;

        public CategoriaController()
        {

            _categoraia = new List<Categoria>()
            {
                new Categoria()
                {
                    Codigo =1,
                    Descrição = "Bebidas"
                },

                new Categoria()
                {
                    Codigo =2,
                    Descrição = "Alimentos"
                }

                
            };
        }

        [HttpGet("/lista")]
        public IActionResult ListaCategoria()
        {
            return Ok(_categoraia);
        }        [HttpPost("/Categoria")]



        public IActionResult ListaCategoria(CategoriaDTO categoria)
        {
            return Ok(_categoraia.Where(x=>x.Codigo==categoria.Codigo));
        }


    }
}
