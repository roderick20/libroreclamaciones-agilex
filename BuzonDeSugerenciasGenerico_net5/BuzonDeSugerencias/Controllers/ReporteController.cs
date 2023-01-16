using BuzonDeSugerencias.Models;
using ClosedXML.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using ClosedXML.Excel;

namespace BuzonDeSugerencias.Controllers
{
    public class ReporteController : Controller
    {
        private readonly DBContext _context;
        //private IOrderedQueryable<Solicitud> list;

        public ReporteController(DBContext context)
        {
            _context = context;
        }

        // GET: ReporteController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(String fechaInicio, String fechaFin)
        {
            var DbF = Microsoft.EntityFrameworkCore.EF.Functions;

            string[] formats = { "dd/MM/yyyy" };
            var fechaInicioDT = DateTime.ParseExact(fechaInicio, formats, new CultureInfo("en-US"), DateTimeStyles.None);
            var fechaFinDT = DateTime.ParseExact(fechaFin, formats, new CultureInfo("en-US"), DateTimeStyles.None);


            var list = _context.Solicituds.OrderBy(m => m.Fecha >= fechaInicioDT && m.Fecha <= fechaFinDT).ToList();


            var wb = new ClosedXML.Excel.XLWorkbook();
            var ws = wb.AddWorksheet();
            int cont = 2;


            ws.Range("A" + cont, "R" + cont).Style.Fill.SetBackgroundColor(XLColor.FromArgb(79, 129, 189));
            ws.Range("A" + cont, "R" + cont).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thick);
            ws.Range("A" + cont, "R" + cont).Style.Border.SetOutsideBorderColor(XLColor.FromArgb(149, 179, 215));
            ws.Range("A" + cont, "R" + cont).Style.Font.SetFontColor(XLColor.White);


            ws.Cell("A" + cont).Value = "Número";
            ws.Cell("B" + cont).Value = "Fecha";
            ws.Cell("C" + cont).Value = "Apellidos";
            ws.Cell("D" + cont).Value = "Nombres";
            ws.Cell("E" + cont).Value = "Correo";
            ws.Cell("F" + cont).Value = "Domicilio";
            ws.Cell("G" + cont).Value = "DNI";
            ws.Cell("H" + cont).Value = "Nombre Padre o Madre";
            ws.Cell("I" + cont).Value = "Teléfono";
            ws.Cell("J" + cont).Value = "Mayoria de Edad";
            ws.Cell("K" + cont).Value = "Bien Contratado";
            ws.Cell("L" + cont).Value = "Nombre del Bien Contratado";
            ws.Cell("M" + cont).Value = "Monto Reclamado";
            ws.Cell("N" + cont).Value = "Tipo de Informe";
            ws.Cell("O" + cont).Value = "Escuela";
            ws.Cell("P" + cont).Value = "Título";
            ws.Cell("Q" + cont).Value = "Descripción";
            ws.Cell("R" + cont).Value = "Estado";
            ws.Cell("S" + cont).Value = "Respuesta";
            ws.Cell("T" + cont).Value = "Fecha de Respuesta";

            cont++;

            foreach (var item in list)
            {

                ws.Cell("A" + cont).Value = item.Id;
                ws.Cell("B" + cont).Value = item.Fecha;
                ws.Cell("C" + cont).Value = item.ApellidoPaterno + " " + item.ApellidoMaterno;
                ws.Cell("D" + cont).Value = item.Nombres;
                ws.Cell("E" + cont).Value = item.Correo;
                ws.Cell("F" + cont).Value = item.Domicilio;
                ws.Cell("G" + cont).Value = item.Dni;
                ws.Cell("H" + cont).Value = item.PadreNombre;
                ws.Cell("I" + cont).Value = item.Telefono;
                ws.Cell("J" + cont).Value = item.MayoriaDeEdad ? "Si" : "No";
                ws.Cell("K" + cont).Value = item.BienContratado;
                ws.Cell("L" + cont).Value = item.NombreDelBienContratado;
                ws.Cell("M" + cont).Value = item.MontoReclamado;
                ws.Cell("N" + cont).Value = item.TipoDeInforme;
                ws.Cell("O" + cont).Value = item.Escuela;
                ws.Cell("P" + cont).Value = item.Titulo;
                ws.Cell("Q" + cont).Value = item.Descripcion;
                switch (item.Estado)
                {
                    case 1:
                        ws.Cell("R" + cont).Value = "Abierto";
                        ws.Range("R" + cont).Style.Font.SetFontColor(XLColor.FromHtml("#A91E2C"));
                        break;
                    case 2:
                        ws.Cell("R" + cont).Value = "Cerrado";
                        ws.Range("R" + cont).Style.Font.SetFontColor(XLColor.FromHtml("#18634B"));
                        break;
                    case 3:
                        ws.Cell("R" + cont).Value = "Spam";
                        ws.Range("R" + cont).Style.Font.SetFontColor(XLColor.FromHtml("#0056B3"));
                        break;
                }

                ws.Cell("S" + cont).Value = item.Respuesta;
                ws.Cell("T" + cont).Value = item.FechaDeRespuesta;

                cont++;
            }
            ws.Columns("A", "T").AdjustToContents();

            return wb.Deliver("HolaDeReclamos.xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");


        }


    }
}
