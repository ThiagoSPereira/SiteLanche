using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDextraRegrasDeNegocios.Calculos
{
    public class PromocaoLancheLight : Promocao
    {
        public decimal PromocaoDeLanche(List<int> ingredientes, decimal preco)
        {
            bool descontoLancheLigth = ingredientes.Any(id => id == 1) && !ingredientes.Any(id => id == 2);

            if (!descontoLancheLigth)
                return preco;

            return preco - preco * 0.1m;
        }
    }
}
