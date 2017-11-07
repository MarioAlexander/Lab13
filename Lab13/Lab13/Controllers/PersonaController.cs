using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab13.Models;

namespace Lab13.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonalD = 1,
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "Av. Evergreen 123",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@nail.con"
            });
            personas.Add(new Persona
            {
                PersonalD = 1,
                Nombre = "Maria",
                Apellido = "Salas",
                Direccion = "Av. Progreso 325",
                FechaNac = Convert.ToDateTime("1995-10-28"),
                Email = "maria@rnail.con"
            });
            personas.Add(new Persona
            {
                PersonalD = 1,
                Nombre = "Carlos",
                Apellido = "Martinez",
                Direccion = "Av. Los manzanos IBI",
                FechaNac = Convert.ToDateTime("1982-02-14"),
                Email = "carlos@nail.con"
            });
            return View(personas);
        }
    }

}