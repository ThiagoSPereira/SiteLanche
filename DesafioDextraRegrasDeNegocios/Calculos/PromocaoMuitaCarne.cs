using DesafioDextraData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDextraRegrasDeNegocios.Calculos
{
    public class PromocaoMuitaCarne : Promocao
    {
        Cardapio cardapio = new Cardapio();
        public decimal PromocaoDeLanche(List<int> ingredientesId, decimal preco)
        {
            int numerodeCarne = ingredientesId.Where(ingrediente => ingrediente == 3).Count();
            bool temPromacaoCarne = numerodeCarne > 2;

            if (!temPromacaoCarne)
                return preco;

            int numeroDeRetirada = numerodeCarne / 3;
            decimal valor = cardapio.ObterCardapioIngredientes().Where(ingrediente => ingrediente.IngredienteId == 3)
                .FirstOrDefault().Valor * numeroDeRetirada;

            preco -= valor;
            return preco;
        }
    }
}
