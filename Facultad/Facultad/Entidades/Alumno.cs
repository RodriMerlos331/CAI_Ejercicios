using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    internal class Alumno : Persona
    {
        //Atributo
        private int _codigo;

        public int Codigo { get => _codigo; set => _codigo = value; }

        protected override void GetCredencial()
        {
            
        }
    }
}
