using System.Linq;
using BuzonDeSugerencias.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BuzonDeSugerencias.Controllers
{
	public class AdminController : Controller
	{
		private readonly DBContext _context;
		public IConfiguration Configuration { get; }

		public AdminController(DBContext context, IConfiguration configuration)
		{
			_context = context;
			Configuration = configuration;
		}

		public IActionResult Index()
		{

			return View();
		}

		[Route("Login")]
		public IActionResult Login()
		{
			ViewBag.Empresa = Configuration["Reclamos:Empresa"];
			ViewBag.Direcion = Configuration["Reclamos:Direccion"];
			ViewBag.RUC = Configuration["Reclamos:RUC"];
			ViewBag.Logo = Configuration["Reclamos:Logo"];
			ViewBag.Banner = Configuration["Reclamos:Banner"];
			ViewBag.NombreComercial = Configuration["Reclamos:NombreComercial"];
			ViewBag.Url = Configuration["Reclamos:Url"];
			return View();
		}

		[Route("Login")]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Login(string email, string password, string captchaCode)
		{
			ViewBag.Empresa = Configuration["Reclamos:Empresa"];
			ViewBag.Direcion = Configuration["Reclamos:Direccion"];
			ViewBag.RUC = Configuration["Reclamos:RUC"];
			ViewBag.Logo = Configuration["Reclamos:Logo"];
			ViewBag.Banner = Configuration["Reclamos:Banner"];
			ViewBag.NombreComercial = Configuration["Reclamos:NombreComercial"];
			ViewBag.Url = Configuration["Reclamos:Url"];

			if (captchaCode != base.HttpContext.Session.GetString("CaptchaCode"))
			{
				base.ModelState.AddModelError(string.Empty, "Error en captcha");
				return View();
			}
			if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
			{
				base.ViewBag.Message = "Email y contraseña son obligatorios";
				return View();
			}
			User user = _context.Users.Where((User u) => u.Email.Equals(email) && u.Password.Equals(password)).FirstOrDefault();
			if (user == null)
			{
				base.ViewBag.Message = "Email y contraseña erroneos";
			}
			else
			{
				if (user.Enabled)
				{
					base.HttpContext.Session.SetInt32("UserId", user.Id);
					base.HttpContext.Session.SetInt32("IsAdmin", user.IsAdmin ? 1 : 0);
					base.HttpContext.Session.SetString("UserName", user.FirstName + " " + user.LastName);
					return RedirectToAction("Index", "Admin");
				}
				base.ViewBag.Message = "Usuario esta inhabilitado";
			}
			return View();
		}

		[Route("Logout")]
		public IActionResult Logout()
		{
			base.HttpContext.Session.Clear();
			return RedirectToAction("Login", "Admin", new
			{
				Area = ""
			});
		}

		[Route("ActualizarPassword")]
		public IActionResult CambioContrasena()
		{
			return View();
		}

		[Route("ActualizarPassword")]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult CambioContrasena(string Contrasena1)
		{
			if (string.IsNullOrEmpty(Contrasena1))
			{
				base.ModelState.AddModelError(string.Empty, "Ingrese contraseña");
			}
			else
			{
				//if (Contrasena1.Equals(Contrasena2))
				//{
					User user = _context.Users.Find(base.HttpContext.Session.GetInt32("UserId"));
					user.Password = Contrasena1;
					_context.Update(user);
					_context.SaveChanges();
				ViewBag.Mensaje = "Contraseña actualizada";
				//}
				//base.ModelState.AddModelError(string.Empty, "Las contraseñas no son iguales");
			}
			return View();
		}
	}
}
