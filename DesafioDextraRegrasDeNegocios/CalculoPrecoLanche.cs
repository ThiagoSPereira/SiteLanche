using DesafioDextraData;
using DesafioDextraRegrasDeNegocios.Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDextraRegrasDeNegocios
{
    public class CalculoPrecoLanche
    {
        Cardapio cardapio = new Cardapio();

        public decimal CalcularPrecoDoLanche(List<int> ingredientesId)
        {
            decimal preco = 0m;

            foreach(var id in ingredientesId)
            {
               var valor = cardapio.ObterCardapioIngredientes().Where(ingrediente => ingrediente.IngredienteId == id)
                    .FirstOrDefault().Valor;
                preco += valor;
            }

            Promocao promocaoCarne = new PromocaoMuitaCarne();
            Promocao promocaoQueijo = new PromocaoMuitoQueijo();
            Promocao promocaoLight = new PromocaoLancheLight();

            CalculaPromocao promocao = new CalculaPromocao();

            preco = promocao.CalcularPromocao(ingredientesId, preco, promocaoCarne);
            preco = promocao.CalcularPromocao(ingredientesId, preco, promocaoQueijo);
            preco = promocao.CalcularPromocao(ingredientesId, preco, promocaoLight);

            return preco;

        }



        


    }
}
