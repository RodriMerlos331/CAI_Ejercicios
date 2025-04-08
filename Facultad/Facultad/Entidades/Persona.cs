using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    public abstract class Persona
    {
        //Atributos
        private string _apellido;
        private string _nombre;
        private DateTime _fechaNac;

        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }

        public abstract void GetCredencial();

        protected virtual void GetNombreCompleto()
        {

        }
        protected void GetSaludoInformal()
        {

        }

    }

}

