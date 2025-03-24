using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    public abstract class Empleado : Persona
    {
        //Atributos
        private int _legajo;
        private DateTime _fechaIngreso;

        //Propiedades
        public int Legajo { get => _legajo; set => _legajo = value; }
        public DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }

        //Propiedades Heredadas
        public DateTime FechaNacimiento { get => FechaNac; set => FechaNac = value; }

        //Propiedad Custom
        public int Antiguedad { get => (DateTime.Now - _fechaIngreso).Days / 365; }

        //Metodos
        public override string GetCredencial()
        {

        }
    }
}
