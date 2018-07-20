using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDextraRegrasDeNegocios.Calculos
{
    public interface Promocao
    {
        decimal PromocaoDeLanche(List<int> ingredientes, decimal preco);
    }
}
