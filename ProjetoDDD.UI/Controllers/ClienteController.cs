using AutoMapper;
using ProjetoDDD.Application.Interfaces;
using ProjetoDDD.Domain.Entities;

using ProjetoDDD.UI.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoDDD.UI.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteAppService _clienteApp;

        public ClienteController(IClienteAppService clienteApp)
        {
            _clienteApp = clienteApp;
        }


        // GET: Cliente
        public ActionResult Index()
        {
            var ClienteView = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteApp.ObterTodos());           
            return View(ClienteView);
        }

        //GET: Cliente/Especiais
        public ActionResult Especiais()
        {
            var clienteEspecial = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteApp.ObterTodos());
            return View(clienteEspecial);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            var ClienteDetails = Mapper.Map<Cliente, ClienteViewModel>(_clienteApp.ObterPorId(id));
            return View(ClienteDetails);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(ClienteViewModel cliente)
        {
            var clienteCreate = Mapper.Map<ClienteViewModel, Cliente>(cliente);
            if (_clienteApp.CadastroRepetido(clienteCreate) == true)
            {
                return View();
            }
            else
                if (_clienteApp.ClienteNaoAtivo(clienteCreate) == true){

                return View();
            }
            else
            _clienteApp.Add(clienteCreate);
            return RedirectToAction("Index");
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            var clienteView = Mapper.Map<Cliente, ClienteViewModel>(_clienteApp.ObterPorId(id));
          
            return View(clienteView);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult EditConfirmar(int id)
        {
            var clienteEdit = _clienteApp.ObterPorId(id);
            var clienteView = Mapper.Map<Cliente, ClienteViewModel>(clienteEdit);

            return View(clienteView);
         
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            var ClienteDelete = Mapper.Map<Cliente, ClienteViewModel>(_clienteApp.ObterPorId(id));
            return View(ClienteDelete);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmar(int id)
        {
            var ClienteDelete = _clienteApp.ObterPorId(id);
            _clienteApp.Delete(ClienteDelete);
            return RedirectToAction("Index");
        }
    }
}
