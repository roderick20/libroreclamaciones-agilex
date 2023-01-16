using System;
using System.Collections.Generic;

#nullable disable

namespace BuzonDeSugerencias.Models
{
    public partial class Solicitud
    {
        public int Id { get; set; }
        public Guid UniqueId { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Nombres { get; set; }
        public string Correo { get; set; }
        public string Domicilio { get; set; }
        public string Dni { get; set; }
        public string PadreNombre { get; set; }
        public int? Telefono { get; set; }
        public bool MayoriaDeEdad { get; set; }
        public string BienContratado { get; set; }
        public string NombreDelBienContratado { get; set; }
        public decimal? MontoReclamado { get; set; }
        public string TipoDeInforme { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int Estado { get; set; }
        public int TipoDoc { get; set; }
        public string Respuesta { get; set; }
        public DateTime? FechaDeRespuesta { get; set; }
        public string Escuela { get; set; }
    }
}
