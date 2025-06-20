﻿using System;

namespace Entidad
{
    public class Tipo_Empleado
    {
        public int Id_TipoEmpleado { get; set; }

        private string descripcion;
        public string Descripcion
        {
            get => descripcion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La descripción del tipo de empleado no puede estar vacía.");
                descripcion = value;
            }
        }

        public Tipo_Empleado() { }

        public Tipo_Empleado(int id_tipoEmpleado, string descripcion)
        {
            Id_TipoEmpleado = id_tipoEmpleado;
            Descripcion = descripcion;
        }
    }
}
