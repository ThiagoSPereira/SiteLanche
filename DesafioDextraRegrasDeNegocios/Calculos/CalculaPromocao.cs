using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDextraRegrasDeNegocios.Calculos
{
    public class CalculaPromocao
    {
        public decimal CalcularPromocao(List<int> ingredientes, decimal preco, Promocao promocao)=>        
             promocao.PromocaoDeLanche(ingredientes, preco);
        
    }
}
