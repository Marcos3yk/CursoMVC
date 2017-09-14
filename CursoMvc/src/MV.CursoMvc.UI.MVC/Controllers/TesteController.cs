using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MV.CursoMvc.UI.MVC.Controllers
{
    [RoutePrefix("ADM/Gestao/Clientes")]
    [Route("{action=index}")]
    public class TesteController : Controller
    {
        // GET: Teste
        [Route("Lista")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("Cliente/{idcliente:int}/Editar/{idcategoria:int}/Categoria")]
        public ActionResult Editar(int idcliente, int idcategoria)
        {
            return View("Index");
        }
    }
}