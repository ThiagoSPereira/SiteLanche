using DesafioDextraData;
using DesafioDextraData.Model;
using DesafioDextraRegrasDeNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace DesafioDextra.Controllers
{
    public class CardapioController : Controller
    {
        Cardapio cardapio = new Cardapio();
        CalculoPrecoLanche calculoPreco = new CalculoPrecoLanche();

        public ActionResult Index()
        {
            
            List<Lanche> lanches = cardapio.ObterCardapioLanches().ToList(); 
            return View(lanches);
        }

        public ActionResult CriarLanche()
        {
            List<Ingrediente> ingredientes = cardapio.ObterCardapioIngredientes();
            return View(ingredientes);
        }

       

    }
}