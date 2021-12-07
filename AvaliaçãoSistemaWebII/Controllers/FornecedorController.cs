using AvaliaçãoSistemaWebII.Context;
using AvaliaçãoSistemaWebII.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AvaliaçãoSistemaWebII.Controllers
{
    public class FornecedorController : Controller
    {
        private EFContext context = new EFContext();

        // GET: Bibliotecario
        public ActionResult Index()
        {
            return View(context.fornecedor.OrderBy(c => c.Nome));
        }

        // GET: Bibliotecario/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Fornecedor fornecedor = context.fornecedor.Find(id);
            if (fornecedor == null)
            {
                return HttpNotFound();
            }
            return View(fornecedor);
        }

        // GET: Bibliotecario/Create
        public ActionResult Create()
        {
            ViewBag.ProdutoId = new SelectList(context.produto.OrderBy(b => b.Nome),
            "ProdutoId", "Nome");            
            return View();
        }

        // POST: Bibliotecario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Fornecedor fornecedor)
        {
            context.fornecedor.Add(fornecedor);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Bibliotecario/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Fornecedor fornecedor = context.fornecedor.Find(id);
            if (fornecedor == null)
            {
                return HttpNotFound();
            }
            return View(fornecedor);
        }

        // POST: Bibliotecario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                context.Entry(fornecedor).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fornecedor);
        }

        // POST: Bibliotecario/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Fornecedor fornecedor = context.fornecedor.Find(id);
            if (fornecedor == null)
            {
                return HttpNotFound();
            }
            return View(fornecedor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            Fornecedor fornecedor = context.fornecedor.Find(id);
            context.fornecedor.Remove(fornecedor);
            context.SaveChanges();
            TempData["Message"] = "Fornecedor *" + fornecedor.Nome.ToUpper() + " FOI REMOVIDO ";
            return RedirectToAction("Index");
        }
    }
}
