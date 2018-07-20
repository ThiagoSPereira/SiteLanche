using DesafioDextraData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDextraRegrasDeNegocios.Calculos
{
    public class PromocaoMuitoQueijo : Promocao
    {
        Cardapio cardapio = new Cardapio();
        public decimal PromocaoDeLanche(List<int> ingredientesId, decimal preco)
        {
            int numerodeQueijo = ingredientesId.Where(ingrediente => ingrediente == 5).Count();
            bool temPromacaoQueijo = numerodeQueijo> 2;

            if (!temPromacaoQueijo)
                return preco;

            int numeroDeRetirada = numerodeQueijo / 3;
            decimal valor = cardapio.ObterCardapioIngredientes().Where(ingrediente => ingrediente.IngredienteId == 5)
                .FirstOrDefault().Valor * numeroDeRetirada;

            preco -= valor;
            return preco;
        }
    }
}
