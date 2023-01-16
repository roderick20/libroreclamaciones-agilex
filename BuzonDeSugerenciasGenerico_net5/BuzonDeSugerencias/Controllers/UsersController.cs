using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using BuzonDeSugerencias.Helper;
using BuzonDeSugerencias.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace BuzonDeSugerencias.Controllers
{
	public class UsersController : Controller
	{
		private readonly DBContext _context;

		public UsersController(DBContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			return View();
		}

		public async Task<IActionResult> IndexData(DataTableRequest request)
		{
			dynamic datatable = new JObject();
			datatable.draw = request.Draw;
			//if (_003C_003Eo__3._003C_003Ep__1 == null)
			//{
			//	_003C_003Eo__3._003C_003Ep__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "recordsTotal", typeof(UsersController), new CSharpArgumentInfo[2]
			//	{
			//		CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
			//		CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
			//	}));
			//}
			//Func<CallSite, object, int, object> target = _003C_003Eo__3._003C_003Ep__1.Target;
			//CallSite<Func<CallSite, object, int, object>> _003C_003Ep__ = _003C_003Eo__3._003C_003Ep__1;
			//object arg = datatable;
			//target(_003C_003Ep__, arg, await _context.Users.CountAsync());
			IOrderedQueryable<User> list = _context.Users.OrderBy((User d) => d.LastName);
			if (!string.IsNullOrEmpty(request.Search.Value))
			{
				list = (IOrderedQueryable<User>)list.Where((User m) => m.NumberDoc.Contains(request.Search.Value) || m.FirstName.Contains(request.Search.Value) || m.LastName.Contains(request.Search.Value));
			}
			int contFilter = list.Count();
			datatable.recordsFiltered = contFilter;
			List<User> listFiltered = list.Skip(request.Start).Take(request.Length).ToList();
			datatable.data = new JArray();
			foreach (User item in listFiltered)
			{
				dynamic obj = new JObject();
				obj.Id = item.Id;
				obj.UniqueId = item.UniqueId;
				obj.TypeDoc = item.TypeDoc;
				obj.NumberDoc = item.NumberDoc;
				obj.Name = item.FirstName + " " + item.LastName;
				obj.Email = item.Email;
				obj.CellPhone = item.CellPhone;
				obj.Phone = item.Phone;
				obj.Password = item.Password;
				obj.Created = item.Created;
				obj.Modified = item.Modified;
				obj.LastAccess = item.LastAccess.ToString("dd/MM/yyyy");
				obj.Enabled = (item.Enabled ? "Activo" : "Baja");
				obj.RecibeEmail = (item.RecibeEmail ? "Si" : "No");
				obj.IsAdmin = (item.IsAdmin ? "Si" : "No");
				datatable.data.Add(obj);
			}
			return this.Content(datatable.ToString(), "application/json");
		}

		public async Task<IActionResult> Details(int? id)
		{
			if (!id.HasValue)
			{
				return NotFound();
			}
			User user = await _context.Users.FirstOrDefaultAsync((User m) => (int?)m.Id == id);
			if (user == null)
			{
				return NotFound();
			}
			return View(user);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,UniqueId,TypeDoc,NumberDoc,FirstName,LastName,Email,CellPhone,Phone,Password,Created,Modified,LastAccess,Enabled,RecibeEmail,IsAdmin")] User user)
		{
			try
			{
				user.TypeDoc = "";
				user.NumberDoc = "";
				user.LastName = "";
				user.CellPhone = "";
				user.Phone = "";
				user.UniqueId = Guid.NewGuid();
				user.Created = DateTime.Now;
				user.Modified = DateTime.Now;
				user.LastAccess = DateTime.Now;
				_context.Add(user);
				await _context.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			catch(Exception ex){

            }
			return View(user);
		}

		public async Task<IActionResult> Edit(int? id)
		{
			if (!id.HasValue)
			{
				return NotFound();
			}
			User user = await _context.Users.FindAsync(id);
			if (user == null)
			{
				return NotFound();
			}
			return View(user);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,UniqueId,TypeDoc,NumberDoc,FirstName,LastName,Email,CellPhone,Phone,Password,Created,Modified,LastAccess,Enabled,RecibeEmail,IsAdmin")] User user)

		{


				try
				{
				user.TypeDoc = "";
				user.NumberDoc = "";
				user.LastName = "";
				user.CellPhone = "";
				user.Phone = "";
				_context.Update(user);
					await _context.SaveChangesAsync();
					return RedirectToAction("Index");
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!UserExists(user.Id))
					{
						return NotFound();
					}
					throw;
				}

			return View(user);
		}

		public async Task<IActionResult> Delete(int? id)
		{
			if (!id.HasValue)
			{
				return NotFound();
			}
			User user = await _context.Users.FirstOrDefaultAsync((User m) => (int?)m.Id == id);
			if (user == null)
			{
				return NotFound();
			}
			return View(user);
		}

		[HttpPost]
		[ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			User user = await _context.Users.FindAsync(id);
			_context.Users.Remove(user);
			await _context.SaveChangesAsync();
			return RedirectToAction("Index");
		}

		private bool UserExists(int id)
		{
			return _context.Users.Any((User e) => e.Id == id);
		}
	}
}
