using DesafioDextraData;
using DesafioDextraRegrasDeNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace DesafioDextra.Controllers
{
    public class PrecosController : ApiController
    {
        Cardapio cardapio = new Cardapio();
        CalculoPrecoLanche calculoPreco = new CalculoPrecoLanche();

        public IHttpActionResult Post([FromBody]List<int> ingredientesId)
        {
            var valor = calculoPreco.CalcularPrecoDoLanche(ingredientesId);
            return Json(new { preco = valor});
        }

     }
}
