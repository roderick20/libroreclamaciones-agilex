using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BuzonDeSugerencias.Models
{
	[ModelMetadataType(typeof(Solicitud))]
	public partial class Solicitud
	{
	}
	public interface SolicitudMetaData
	{
		[Display(Name = "Apellidos")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		string Apellidos
		{
			get;
			set;
		}

		[Display(Name = "Nombre")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		string Nombres
		{
			get;
			set;
		}

		[Display(Name = "Correo Electrónico")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		string Correo
		{
			get;
			set;
		}

		[Display(Name = "Domicilio")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		string Domicilio
		{
			get;
			set;
		}

		[Display(Name = "TipoDoc")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		string TipoDoc
		{
			get;
			set;
		}

		[Display(Name = "Documento")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		int Dni
		{
			get;
			set;
		}

		[Display(Name = "Teléfono")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		int Telefono
		{
			get;
			set;
		}

		[Display(Name = "Mayoria de edad")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		bool MayoriaDeEdad
		{
			get;
			set;
		}

		[Display(Name = "Bien contratado")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		string BienContratado
		{
			get;
			set;
		}

		[Display(Name = "Nombre del bien contratado")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		string NombreDelBienContratado
		{
			get;
			set;
		}

		[Display(Name = "Tipo de informe")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		string TipoDeInforme
		{
			get;
			set;
		}

		[Display(Name = "Titulo")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		string Titulo
		{
			get;
			set;
		}

		[Display(Name = "Descripción")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		string Descripcion
		{
			get;
			set;
		}

		[Display(Name = "Fecha")]
		string Fecha
		{
			get;
			set;
		}
	}
}
