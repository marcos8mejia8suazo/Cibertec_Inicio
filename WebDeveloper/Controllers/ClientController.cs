using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    [Authorize]
    public class ClientController : Controller
    {

        //private ClientData _client;

        // GET: Client
        private IDataAccess<Client> _client;
        public ClientController(IDataAccess<Client> client)
        {
            _client = client;
        }
        public ActionResult Index()
        {
            
            return View(_client.GetList());
        }

        public ActionResult Create()
        {
            return View(new Client());
        }

        [HttpPost]
        public ActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {
                _client.Add(client);
                return RedirectToAction("Index");
            }
            return View();
        }

        //public ActionResult Delete(int id)
        //{
        //    var client = _client.GetClient(id);
        //    if(client == null)
        //    {
        //        RedirectToAction("Index");
        //    }return View(client);
        //}

        [HttpPost]
        public ActionResult Delete(Client client)
        {
            if (_client.Delete(client) > 0)
            {
                return RedirectToAction("Index");
            }return View(client);
        }


        
    }
}