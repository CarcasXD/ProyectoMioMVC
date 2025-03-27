using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProyectoMioMVC.Models;
using static ProyectoMioMVC.Models.Equipo;

namespace ProyectoMioMVC.Controllers
{
    public class EquipoController : Controller
    {
        private readonly equiposDbContext _equiposDbContext;

        public EquipoController(equiposDbContext equiposDbContext) 
        {
            _equiposDbContext = equiposDbContext;
        }
        public IActionResult Index()
        {
            var listadoDeMarcas = (from m in _equiposDbContext.marcas
                                   select m).ToList();
            ViewData["listadoDeMarcas"] = new SelectList(listadoDeMarcas, "id_marcas", "nombre_marca");
            var listadoDeEquipos = (from e in _equiposDbContext.Equipo
                                    join m in _equiposDbContext.marcas on e.marca_id equals m.id_marcas
                                    select new
                                    {
                                        nombre = e.nombre,
                                        descripcion = e.descripcion,
                                        marca_id = e.marca_id,
                                        marca_nombre = m.nombre_marca
                                    }).ToList();

            ViewData["ListadoEquipo"] = listadoDeEquipos;

            return View();
        }
        public IActionResult CrearEquipos(Equipo nuevoEquipo)
        {
            _equiposDbContext.Add(nuevoEquipo);
            _equiposDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
