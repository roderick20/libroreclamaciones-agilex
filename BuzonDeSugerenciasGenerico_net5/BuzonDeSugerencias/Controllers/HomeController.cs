using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BuzonDeSugerencias.Helper;
using BuzonDeSugerencias.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BuzonDeSugerencias.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly DBContext _context;
        private readonly IWebHostEnvironment _env;
        public IConfiguration Configuration { get; }

        public HomeController(ILogger<HomeController> logger, DBContext context, IWebHostEnvironment env, IConfiguration configuration)
        {
            _env = env;
            _logger = logger;
            _context = context;
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewBag.Empresa = Configuration["Reclamos:Empresa"];
            ViewBag.Direcion = Configuration["Reclamos:Direccion"];
            ViewBag.RUC = Configuration["Reclamos:RUC"];
            ViewBag.Logo = Configuration["Reclamos:Logo"];
            ViewBag.Banner = Configuration["Reclamos:Banner"];
            ViewBag.NombreComercial = Configuration["Reclamos:NombreComercial"];
            ViewBag.Url = Configuration["Reclamos:Url"];
            Solicitud solicitud = new Solicitud();
            return View(solicitud);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind(new string[]
        {

            "Id,UniqueId,ApellidoPaterno,ApellidoMaterno,Escuela,Nombres,Correo,Domicilio,TipoDoc,Dni,Telefono,MayoriaDeEdad,BienContratado,NombreDelBienContratado,TipoDeInforme,Titulo,Descripcion,PadreNombre,MontoReclamado"
        })] Solicitud solicitud, bool terminos, string captchaCode)
        {
            ViewBag.Empresa = Configuration["Reclamos:Empresa"];
            ViewBag.Direcion = Configuration["Reclamos:Direccion"];
            ViewBag.RUC = Configuration["Reclamos:RUC"];
            ViewBag.Logo = Configuration["Reclamos:Logo"];
            ViewBag.Banner = Configuration["Reclamos:Banner"];
            ViewBag.NombreComercial = Configuration["Reclamos:NombreComercial"];
            ViewBag.Url = Configuration["Reclamos:Url"];

            try
            {

            if(!IsValidEmail2(solicitud.Correo)) {
                    base.ModelState.AddModelError(string.Empty, "Correo electrónico incorrecto.");
                    return View(solicitud);
                }

                if (captchaCode != base.HttpContext.Session.GetString("CaptchaCode"))
                {
                    base.ModelState.AddModelError(string.Empty, "Error en captcha");
                    return View(solicitud);
                }
                if (solicitud.TipoDoc == 1)
                {
                    if (solicitud.Dni == null)
                    {
                        base.ModelState.AddModelError(string.Empty, "DNI debe tener 8 caracteres");
                        return View(solicitud);
                    }
                    if (solicitud.Dni.Length != 8)
                    {
                        base.ModelState.AddModelError(string.Empty, "DNI debe tener 8 caracteres");
                        return View(solicitud);
                    }
                }
                if (!solicitud.MayoriaDeEdad)
                {
                    if (string.IsNullOrEmpty(solicitud.PadreNombre))
                    {
                        base.ModelState.AddModelError(string.Empty, "Si es menor de edad, el campo \"Nombre de Padre o Madre\" es obligatorio");
                        return View(solicitud);
                    }
                }
                else
                {
                    solicitud.PadreNombre = "";
                }
                solicitud.UniqueId = Guid.NewGuid();
                solicitud.Fecha = DateTime.Now;
                solicitud.Estado = 1;
                _context.Add(solicitud);
                await _context.SaveChangesAsync();


                var path = _env.WebRootPath + "/TplEmail/tpl.html";
                String fileContents2 = System.IO.File.ReadAllText(path);


                SendEmailSmarter email_obj = new SendEmailSmarter();
                email_obj.SendEmail = Configuration["Reclamos:Email"];
                email_obj.SendPassword = Configuration["Reclamos:EmailPassword"];
                email_obj.MailServer = Configuration["Reclamos:EmailServer"];

                email_obj.ToEmail = solicitud.Correo;
                email_obj.Subject = "Constancia de registro de Hoja de reclamación Nº " + solicitud.Id.ToString().PadLeft(10, '0');
                email_obj.Body = fileContents2;
                email_obj.Logo = _env.WebRootPath + Configuration["Reclamos:LogoEmail"];
                email_obj.Send();

                var path2 = _env.WebRootPath + "/TplEmail/tpl_gestor.html";
                String fileContents = System.IO.File.ReadAllText(path2);
                fileContents = fileContents.Replace("$$NombresApellidos$$", solicitud.Nombres + ", " + solicitud.ApellidoPaterno + " " + solicitud.ApellidoMaterno);
                fileContents = fileContents.Replace("$$CorreoElectronico$$", solicitud.Correo);
                fileContents = fileContents.Replace("$$TelefonoCelular$$", solicitud.Telefono.ToString());
                fileContents = fileContents.Replace("$$Domicilio$$", solicitud.Domicilio);
                fileContents = fileContents.Replace("$$Escuela$$", solicitud.Escuela);

                var TipoDoc = solicitud.TipoDoc == 1 ? "DNI" : "Carnet de Extranjería";
                fileContents = fileContents.Replace("$$TipoDocumentoNumero$$", TipoDoc + ": " + solicitud.Dni);
                var MayoriaDeEdad = solicitud.MayoriaDeEdad ? "SI" : "No";
                fileContents = fileContents.Replace("$$MayoriaEdadNombrePadre$$", MayoriaDeEdad + ", " + solicitud.PadreNombre);
                fileContents = fileContents.Replace("$$BienContratado$$", solicitud.BienContratado);
                fileContents = fileContents.Replace("$$MontoReclamado$$", solicitud.MontoReclamado.ToString());
                fileContents = fileContents.Replace("$$TipoInforme$$", solicitud.TipoDeInforme);
                fileContents = fileContents.Replace("$$Pedido$$", solicitud.Titulo);
                fileContents = fileContents.Replace("$$Detalle$$", solicitud.Descripcion);

                var list = _context.Users.Where(m => m.RecibeEmail).ToList();
                foreach(var item in list)
                {
                    SendEmailSmarter email_obj1 = new SendEmailSmarter();

                    email_obj1.SendEmail = Configuration["Reclamos:Email"];
                    email_obj1.SendPassword = Configuration["Reclamos:EmailPassword"];
                    email_obj1.MailServer = Configuration["Reclamos:EmailServer"];

                    email_obj1.ToEmail = item.Email;
                    email_obj1.Subject = "Nueva Hoja de reclamación Nº " + solicitud.Id.ToString().PadLeft(10, '0');
                    email_obj1.Body = fileContents;
                    email_obj1.Logo = _env.WebRootPath + Configuration["Reclamos:LogoEmail"]; 

                    email_obj1.Send();
                }



                ViewBag.Numero = solicitud.Id;
            }
            catch (Exception ex)
            {
                base.ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(solicitud);
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public bool IsValidEmail2(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public IActionResult Revision()
        {
            ViewBag.Empresa = Configuration["Reclamos:Empresa"];
            ViewBag.Direcion = Configuration["Reclamos:Direccion"];
            ViewBag.RUC = Configuration["Reclamos:RUC"];
            ViewBag.Logo = Configuration["Reclamos:Logo"];
            ViewBag.Banner = Configuration["Reclamos:Banner"];
            ViewBag.NombreComercial = Configuration["Reclamos:NombreComercial"];
            ViewBag.Url = Configuration["Reclamos:Url"];

            ViewBag.Numero = "";
            ViewBag.Email = "";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Revision(int Numero, String Email, String captchaCode)
        {
            ViewBag.Numero = Numero;
            ViewBag.Email = Email;

            ViewBag.Empresa = Configuration["Reclamos:Empresa"];
            ViewBag.Direcion = Configuration["Reclamos:Direccion"];
            ViewBag.RUC = Configuration["Reclamos:RUC"];
            ViewBag.Logo = Configuration["Reclamos:Logo"];
            ViewBag.Banner = Configuration["Reclamos:Banner"];
            ViewBag.NombreComercial = Configuration["Reclamos:NombreComercial"];
            ViewBag.Url = Configuration["Reclamos:Url"];

            try
            {
                if (captchaCode != base.HttpContext.Session.GetString("CaptchaCode"))
                {
                    base.ModelState.AddModelError(string.Empty, "Error en captcha");
                    return View();
                }

                var solicitud = _context.Solicituds.Where(m => m.Correo.ToLower().Equals(Email.ToLower()) && m.Id == Numero).FirstOrDefault();
                if (solicitud == null)
                {
                    ViewBag.Mensaje = "Hoja de Reclamo no existe";

                }
                else
                {
                    if (!String.IsNullOrEmpty(solicitud.Respuesta))
                    {
                        ViewBag.Mensaje = solicitud.Respuesta;
                        ViewBag.MensajeFecha = solicitud.FechaDeRespuesta == null ? "" : Convert.ToDateTime(solicitud.FechaDeRespuesta).ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        ViewBag.Mensaje = "Hoja de Reclamo esta pendiente";
                    }
                }
            }
            catch (Exception)
            {
            }

            return View();
        }

        [Route("get-captcha-image")]
        public IActionResult GetCaptchaImage()
        {
            int width = 100;
            int height = 36;
            string captchaCode = Captcha.GenerateCaptchaCode();
            CaptchaResult result = Captcha.GenerateCaptchaImage(width, height, captchaCode);
            base.HttpContext.Session.SetString("CaptchaCode", result.CaptchaCode);
            Stream s = new MemoryStream(result.CaptchaByteData);
            return new FileStreamResult(s, "image/png");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = (Activity.Current?.Id ?? base.HttpContext.TraceIdentifier)
            });
        }
    }
}
