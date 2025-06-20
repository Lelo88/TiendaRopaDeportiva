﻿using System;

namespace Entidad
{
    public class Vendedor : Empleado
    {
        public Vendedor() { }

        public Vendedor(int id_empleado, string nombre, string apellido, string dni, Tipo_Empleado tipoEmpleado, string usuario, string contrasena)
            : base(id_empleado, nombre, apellido, dni, tipoEmpleado, usuario, contrasena)
        {
        }
    }
}
