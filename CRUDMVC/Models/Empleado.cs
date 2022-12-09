using System;
using System.Collections.Generic;

namespace CRUDMVC.Models
{
    public partial class Empleado
    {
        public int Id { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Direccion { get; set; }
        public string? NumeroTelefono { get; set; }
    }
}
