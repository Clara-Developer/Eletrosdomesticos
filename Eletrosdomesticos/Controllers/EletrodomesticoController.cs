using Eletrosdomesticos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eletrosdomesticos.Controllers
{
    public class EletrodomesticoController : Controller
    {
        public IActionResult Index()
        {
            List<Eletrodomestico> Eletros = new List<Eletrodomestico>
            {
                new Geladeira {Marca = "Brastemp", Modelo = "Frost free", ConsumoEnergetico = 70, CapacidadeLitros = 500, TemFreezer = true},
                new Televisor {Marca = "Toshiba", Modelo = "Dled", ConsumoEnergetico = 88.5, TamanhoTela = 120, EhSmart = false},
                new Televisor {Marca = "TCL", Modelo = "Ld 55", ConsumoEnergetico = 54.9, TamanhoTela = 72, EhSmart = false}
            };
            return View(Eletros);
            
        }
    }
}
