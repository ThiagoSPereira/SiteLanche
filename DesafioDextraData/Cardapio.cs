using DesafioDextraData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDextraData
{
    public class Cardapio
    {

        private List<Lanche> Lanches = new List<Lanche>();
        private List<Ingrediente> Ingredientes = new List<Ingrediente>();

        public Cardapio()
        {
            Ingrediente alface = new Ingrediente { IngredienteId = 1, Nome = "Alface", Valor = 0.4m };
            Ingrediente bacon = new Ingrediente { IngredienteId = 2, Nome = "Bacon", Valor = 2m };
            Ingrediente hamburguer = new Ingrediente { IngredienteId = 3, Nome = "Hambúrguer de carne", Valor = 3m };
            Ingrediente ovo = new Ingrediente { IngredienteId = 4, Nome = "Ovo", Valor = 0.8m };
            Ingrediente queijo = new Ingrediente { IngredienteId = 5, Nome = "Queijo", Valor = 1.5m };

            Ingredientes.Add(alface);
            Ingredientes.Add(bacon);
            Ingredientes.Add(hamburguer);
            Ingredientes.Add(ovo);
            Ingredientes.Add(queijo);

            Lanche xbacon = new Lanche
            {
                LancheId = 1,
                Nome = "X-Bacon",
                Ingredientes = new List<Ingrediente>()
            };

            xbacon.Ingredientes.Add(bacon);
            xbacon.Ingredientes.Add(hamburguer);
            xbacon.Ingredientes.Add(queijo);

            Lanche xburger = new Lanche
            {
                LancheId = 2,
                Nome = "X-Burger",
                Ingredientes = new List<Ingrediente>()
            };

            xburger.Ingredientes.Add(bacon);
            xburger.Ingredientes.Add(hamburguer);

            Lanche xegg = new Lanche
            {
                LancheId = 3,
                Nome = "X-Egg",
                Ingredientes = new List<Ingrediente>()
            };

            xegg.Ingredientes.Add(ovo);
            xegg.Ingredientes.Add(hamburguer);
            xegg.Ingredientes.Add(queijo);

            Lanche xeggBacon = new Lanche
            {
                LancheId = 4,
                Nome = "X-EggBacon",
                Ingredientes = new List<Ingrediente>()
            };

            xeggBacon.Ingredientes.Add(ovo);
            xeggBacon.Ingredientes.Add(hamburguer);
            xeggBacon.Ingredientes.Add(queijo);
            xeggBacon.Ingredientes.Add(bacon);


            Lanches.Add(xbacon);
            Lanches.Add(xburger);
            Lanches.Add(xegg);
            Lanches.Add(xeggBacon);
        }

        public List<Lanche> ObterCardapioLanches()
        {
            return Lanches;
        }

        public List<Ingrediente> ObterCardapioIngredientes()
        {
            return Ingredientes;
        }

    }
}
