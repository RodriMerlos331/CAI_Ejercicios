﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    internal class Facultad
    {
        private List<Alumno> _alumnos;
        private int _cantidadSedes;
        private List<Empleado> _empleados;
        private string _nombre;

        protected List<Alumno> Alumnos { get => _alumnos; set => _alumnos = value; }
        protected int CantidadSedes { get => _cantidadSedes; set => _cantidadSedes = value; }
        protected List<Empleado> Empleados { get => _empleados; set => _empleados = value; }
        protected string Nombre { get => _nombre; set => _nombre = value; }
    }
}
