using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDextraData.Model
{
    public class Lanche
    {
        public int LancheId { get; set; }
        public string Nome { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }
    }
}
