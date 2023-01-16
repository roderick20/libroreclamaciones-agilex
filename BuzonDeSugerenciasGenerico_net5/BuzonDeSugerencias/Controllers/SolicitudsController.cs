using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using BuzonDeSugerencias.Helper;
using BuzonDeSugerencias.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace BuzonDeSugerencias.Controllers
{
    public class SolicitudsController : Controller
    {
        private readonly DBContext _context;
        private readonly IWebHostEnvironment _env;
        //private IOrderedQueryable<Solicitud> list;
        private readonly IConfiguration _configuration;

        public SolicitudsController(DBContext context, IWebHostEnvironment env, IConfiguration configuration)
        {
            _context = context;
            _env = env;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> IndexData(DataTableRequest request)
        {
            dynamic datatable = new JObject();
            datatable.draw = request.Draw;
            datatable.recordsTotal = await _context.Solicituds.CountAsync();
            IOrderedQueryable<Solicitud> list = _context.Solicituds.OrderBy((Solicitud d) => d.Fecha);
            try
            {
                switch (request.Order[0].Column)
                {

                    case 0:
                        if (request.Order[0].Dir == "asc")
                        {
                            list = _context.Solicituds.OrderBy(d => d.Id);
                        }
                        else
                        {
                            list = _context.Solicituds.OrderByDescending(d => d.Id);
                        }
                        break;
                    case 1:
                        if (request.Order[0].Dir == "asc")
                        {
                            list = _context.Solicituds.OrderBy(d => d.Fecha);
                        }
                        else
                        {
                            list = _context.Solicituds.OrderByDescending(d => d.Fecha);
                        }
                        break;
                    case 2:
                        if (request.Order[0].Dir == "asc")
                        {
                            list = _context.Solicituds.OrderBy(d => d.Nombres);
                        }
                        else
                        {
                            list = _context.Solicituds.OrderByDescending(d => d.Nombres);
                        }
                        break;
                    case 3:
                        if (request.Order[0].Dir == "asc")
                        {
                            list = _context.Solicituds.OrderBy(d => d.ApellidoPaterno);
                        }
                        else
                        {
                            list = _context.Solicituds.OrderByDescending(d => d.ApellidoPaterno );
                        }
                        break;
                    case 4:
                        if (request.Order[0].Dir == "asc")
                        {
                            list = _context.Solicituds.OrderBy(d => d.TipoDeInforme);
                        }
                        else
                        {
                            list = _context.Solicituds.OrderByDescending(d => d.TipoDeInforme);
                        }
                        break;
                    case 5:
                        if (request.Order[0].Dir == "asc")
                        {
                            list = _context.Solicituds.OrderBy(d => d.Titulo);
                        }
                        else
                        {
                            list = _context.Solicituds.OrderByDescending(d => d.Titulo);
                        }
                        break;
                    case 6:
                        if (request.Order[0].Dir == "asc")
                        {
                            list = _context.Solicituds.OrderBy(d => d.Estado);
                        }
                        else
                        {
                            list = _context.Solicituds.OrderByDescending(d => d.Estado);
                        }
                        break;
                }

                if (!string.IsNullOrEmpty(request.Search.Value))
                {
                    list = (IOrderedQueryable<Solicitud>)list
                    .Where((Solicitud m) => 
                    m.Nombres.Contains(request.Search.Value) ||
                    m.ApellidoPaterno.Contains(request.Search.Value) ||
                    m.Titulo.Contains(request.Search.Value));
                }
                int contFilter = list.Count();
                datatable.recordsFiltered = contFilter;
                List<Solicitud> listFiltered = list.Skip(request.Start).Take(request.Length).ToList();
                datatable.data = new JArray();
                foreach (Solicitud item in listFiltered)
                {
                    dynamic obj = new JObject();
                    obj.Id = item.Id;
                    obj.UniqueId = item.UniqueId;
                    obj.Name = item.Nombres;
                    obj.Apellidos = item.ApellidoPaterno + " " + item.ApellidoMaterno;
                    obj.Correo = item.Correo;
                    obj.Domicilio = item.Domicilio;
                    obj.Documento = item.Dni;
                    obj.Telefono = item.Telefono;
                    obj.Enabled = (item.MayoriaDeEdad ? "Si" : "No");
                    obj.BienContratado = item.BienContratado;
                    obj.NombreDelBienContratado = item.NombreDelBienContratado;
                    obj.TipoDeInforme = item.TipoDeInforme;
                    obj.Titulo = item.Titulo;
                    obj.Descripcion = item.Descripcion;
                    obj.Fecha = item.Fecha.ToString("dd/MM/yyyy");
                    obj.Estado = item.Estado;
                    obj.Escuela = item.Escuela;
                    datatable.data.Add(obj);
                }
            }catch(Exception ex){

            }
            return this.Content(datatable.ToString(), "application/json");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }
            Solicitud solicitud = await _context.Solicituds.FindAsync(id);
            if (solicitud == null)
            {
                return NotFound();
            }
            return View(solicitud);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind(new string[]
        {
            "Id,UniqueId,Estado,Respuesta"
        })] Solicitud solicitud)
        {
            try
            {
                Solicitud solicitudEdit = await _context.Solicituds.FindAsync(id);
                solicitudEdit.Respuesta = solicitud.Respuesta;
                solicitudEdit.Estado = solicitud.Estado;
                solicitudEdit.FechaDeRespuesta = DateTime.Now;
                _context.Update(solicitudEdit);
                await _context.SaveChangesAsync();

                if (solicitud.Estado == 2)
                {
                    var path = _env.WebRootPath + "/TplEmail/tpl_respuesta.html";
                    String fileContents2 = System.IO.File.ReadAllText(path);
                    fileContents2 = fileContents2.Replace("$$Respuesta$$", solicitudEdit.Respuesta);

                    SendEmailSmarter email_obj = new SendEmailSmarter();
                    email_obj.SendEmail = _configuration["Reclamos:Email"];
                    email_obj.SendPassword = _configuration["Reclamos:EmailPassword"];
                    email_obj.MailServer = _configuration["Reclamos:EmailServer"];

                    email_obj.ToEmail = solicitudEdit.Correo;
                    email_obj.Subject = "Respuesta de Hoja de reclamación Nº " + solicitudEdit.Id.ToString().PadLeft(10, '0');
                    email_obj.Body = fileContents2;
                    email_obj.Logo = _env.WebRootPath + _configuration["Reclamos:LogoEmail"];
                    email_obj.Send();

                }
                return RedirectToAction("Index");
            }
            catch (DbUpdateConcurrencyException)
            {
            }
            return View(solicitud);
        }

        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (!id.HasValue)
        //    {
        //        return NotFound();
        //    }
        //    Solicitud solicitud = await _context.Solicituds.FirstOrDefaultAsync((Solicitud m) => (int?)m.Id == id);
        //    if (solicitud == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(solicitud);
        //}

        //[HttpPost]
        //[ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    Solicitud solicitud = await _context.Solicituds.FindAsync(id);
        //    _context.Solicituds.Remove(solicitud);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

        private bool SolicitudExists(int id)
        {
            return _context.Solicituds.Any((Solicitud e) => e.Id == id);
        }
    }
}
