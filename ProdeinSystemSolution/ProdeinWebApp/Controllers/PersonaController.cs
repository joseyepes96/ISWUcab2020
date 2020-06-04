using ProdeinWebApp.Command;
using ProdeinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProdeinWebApp.Controllers
{
    public class PersonaController
    {
        public Personas verificarPersona(String identificacion)
        {
            var persona = new Personas();
            persona._identificacion = identificacion;
            PersonaCommand uc = new PersonaCommand();
            Personas persona1 = uc.consultarPersona(persona);
            return persona1;
        }
        public bool eliminarPersona(Personas persona)
        {
            var respuesta = false;
            PersonaCommand uc = new PersonaCommand();
            respuesta = uc.eliminarPersona(persona);
            return respuesta;
        }
        public bool modificarPersona(Personas persona)
        {
            bool respuesta = false;
            PersonaCommand pc = new PersonaCommand();
            respuesta = pc.modificarPersona(persona);
            return respuesta;
        }

    }
}