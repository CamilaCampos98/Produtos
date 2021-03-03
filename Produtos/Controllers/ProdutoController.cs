using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Produtos;


namespace Produtos.Controllers
{
    public class ProdutoController : Controller
    {
        private PRODUTOSTOREEntities db = new PRODUTOSTOREEntities();

        // GET: Produto
        public ActionResult Index()
        {
            var tblProduto = db.tblProduto.Include(t => t.tblCategoriaProduto);
            return View(tblProduto.ToList());
        }

        // GET: Produto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblProduto tblProduto = db.tblProduto.Find(id);
            if (tblProduto == null)
            {
                return HttpNotFound();
            }
            return View(tblProduto);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            ViewBag.ID = new SelectList(db.tblCategoriaProduto, "ID", "Nome");
            return View();
        }

        // POST: Produto/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nome,Descricao,Ativo,Perecivel,CategoriaID")] tblProduto tblProduto)
        {
            if (ModelState.IsValid)
            {
                db.tblProduto.Add(tblProduto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID = new SelectList(db.tblCategoriaProduto, "ID", "Nome", tblProduto.ID);
            return View(tblProduto);
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblProduto tblProduto = db.tblProduto.Find(id);
            if (tblProduto == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID = new SelectList(db.tblCategoriaProduto, "ID", "Nome", tblProduto.ID);
            return View(tblProduto);
        }

        // POST: Produto/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nome,Descricao,Ativo,Perecivel,CategoriaID")] tblProduto tblProduto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblProduto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID = new SelectList(db.tblCategoriaProduto, "ID", "Nome", tblProduto.ID);
            return View(tblProduto);
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblProduto tblProduto = db.tblProduto.Find(id);
            if (tblProduto == null)
            {
                return HttpNotFound();
            }
            return View(tblProduto);
        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblProduto tblProduto = db.tblProduto.Find(id);
            db.tblProduto.Remove(tblProduto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
