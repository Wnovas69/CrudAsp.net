using CrudAsp.Data.Entities;
using CrudAsp.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudAsp.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarios usuarios;

        public UsuariosController(IUsuarios usuarios)
        {
            this.usuarios = usuarios;
        }

        // GET: UsuariosController
        public ActionResult Index()
        {
       
            var usuarios = this.usuarios.List();
            return View(usuarios);
        }

        // GET: UsuariosController/Details/5
        public ActionResult Details(int id)
        {
            var usuarios = this.usuarios.ObtenerPorId(id);
            return View(usuarios);
        }

        // GET: UsuariosController/Create
        public ActionResult Create()
        {
            return View();
        }
        
        // POST: UsuariosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuarios usuarios)
        {

            this.usuarios.Agregar(usuarios);
            return RedirectToAction(nameof(Index));

        }

        // GET: UsuariosController/Edit/5
        public ActionResult Edit(int id)
        {
            var usuarios = this.usuarios.ObtenerPorId(id);
            return View(usuarios);
        }

        // POST: UsuariosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Usuarios usuarios)
        {
            this.usuarios.Modiificar(usuarios);
            return RedirectToAction(nameof(Index));
        }

        // GET: UsuariosController/Delete/5
        public ActionResult Delete(int id)
        {
            this.usuarios.Remover(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: UsuariosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
