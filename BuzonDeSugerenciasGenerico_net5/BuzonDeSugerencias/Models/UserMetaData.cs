using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace BuzonDeSugerencias.Models
{
	[ModelMetadataType(typeof(User))]
	public partial class User
	{
	}

	public interface UserMetaData
	{
		[Display(Name = "Tipo doc.")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		string TypeDoc
		{
			get;
			set;
		}

		[Display(Name = "Número doc.")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		string NumberDoc
		{
			get;
			set;
		}

		[Display(Name = "Nombre")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		string FirstName
		{
			get;
			set;
		}

		[Display(Name = "Apellido")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		string LastName
		{
			get;
			set;
		}

		string Email
		{
			get;
			set;
		}

		[Display(Name = "Celular")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		string CellPhone
		{
			get;
			set;
		}

		[Display(Name = "Telefono")]
		string Phone
		{
			get;
			set;
		}

		[Display(Name = "Contraseña")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		string Password
		{
			get;
			set;
		}

		[Display(Name = "Creado")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		DateTime Created
		{
			get;
			set;
		}

		[Display(Name = "Modificado")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		DateTime Modified
		{
			get;
			set;
		}

		[Display(Name = "Ultimo Acceso")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		DateTime LastAccess
		{
			get;
			set;
		}

		[Display(Name = "Habilitado")]
		[Required(ErrorMessage = "Campo es obligatorio")]
		bool Enabled
		{
			get;
			set;
		}

		[Display(Name = "Habilitado")]
		[Required(ErrorMessage = "Usuario recibe email de Hoja de Reclamos")]
		public bool RecibeEmail { get; set; }

		[Display(Name = "Habilitado")]
		[Required(ErrorMessage = "Es administrador")]
		public bool IsAdmin { get; set; }
	}
}
