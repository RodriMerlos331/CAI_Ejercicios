using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    internal class Alumno : Persona
    {
        // ATRIBUTOS
        private int _codigo; //declaracion de dato

        public Alumno(string registro) //constructor q recibe un parametro llamdo registro
        {
            String[] datos = registro.Split(';'); //array de datos string "registro.Split hace que el registro se divida con ;
            this.Codigo = int.Parse(datos[0]); //Llama a la propiedad Codigo del objeto actual. Convierte el primer elemento del array ("123") a número entero (int).
            this.Nombre = datos[1]; //Asigna el segundo elemento del array ("Juan") al atributo Nombre heredado de la clase Persona.
            this.Apellido = datos[2]; //Asigna el tercer elemento del array ("Pérez") al atributo Apellido, también heredado.
            this.FechaNac = DateTime.ParseExact(datos[3], "d/M/yyyy", CultureInfo.InvariantCulture);// Método que transforma un texto a un objeto de tipo fecha (DateTime) usando un formato exacto ("día/mes/año").

        }

        // PROPIEDADES
        public int Codigo { get => _codigo; set => _codigo = value; }

        // METODOS
        protected override void GetCredencial()
        {

        }

        public override String ToString()
        {
            return this.Apellido + ", " + this.Nombre + " (" + this.Codigo + ")"; //Devuelve un texto armado con el apellido, nombre y código, por ejemplo: "Pérez, Juan (123)".
        }
    }
}
