using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FornecedoresDDD.Aplicacao.Interfaces;
using FornecedoresDDD.Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FornecedoresDDD.Apresentacao.MVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoApp _produtoApp;

        public ProdutoController(IProdutoApp produtoApp)
        {
            _produtoApp = produtoApp;
        }

        // GET: Produto
        public ActionResult Index()
        {
            return View(_produtoApp.Listar());
        }

        // GET: Produto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produto produto)
        {
            try
            {
                _produtoApp.Adicionar(produto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Produto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produto/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}