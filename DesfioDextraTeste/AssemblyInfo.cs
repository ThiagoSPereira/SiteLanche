using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesafioDextraRegrasDeNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioDextraData;

namespace DesafioDextraRegrasDeNegocios.Tests
{
    
    [TestClass()]
    public class AssemblyInfo
    {
        [TestMethod()]
        public void CalcularPrecoDoLancheTest()
        {
            List<int> ids = new List<int>();
            ids.Add(3);          
            ids.Add(5);

            Cardapio cardapio = new Cardapio();
            var carne = cardapio.ObterCardapioIngredientes()
                .Where(ingrediente => ingrediente.IngredienteId == 3)
                .FirstOrDefault().Valor;

            var queijo = cardapio.ObterCardapioIngredientes()
                .Where(ingrediente => ingrediente.IngredienteId == 5)
                .FirstOrDefault().Valor;


            var precoFinal = queijo + carne;

            CalculoPrecoLanche calculo = new CalculoPrecoLanche();
            Assert.AreEqual(precoFinal, calculo.CalcularPrecoDoLanche(ids));
        }

        [TestMethod()]
        public void CalcularPrecoDoLancheCompromocaoCarneEQueijoTest()
        {
            List<int> ids = new List<int>();
            ids.Add(3);
            ids.Add(3);
            ids.Add(3);
            ids.Add(5);
            ids.Add(5);
            ids.Add(5);

            Cardapio cardapio = new Cardapio();
            var carne = cardapio.ObterCardapioIngredientes()
                .Where(ingrediente => ingrediente.IngredienteId == 3)
                .FirstOrDefault().Valor;

            var queijo = cardapio.ObterCardapioIngredientes()
                .Where(ingrediente => ingrediente.IngredienteId == 5)
                .FirstOrDefault().Valor;


            var precoFinal = (queijo * 2) + (carne * 2); 

            CalculoPrecoLanche calculo = new CalculoPrecoLanche();
            Assert.AreEqual(precoFinal, calculo.CalcularPrecoDoLanche(ids));
        }

        [TestMethod()]
        public void CalcularPrecoDoLancheCompromocaoLigth()
        {
            List<int> ids = new List<int>();
            ids.Add(1);
            ids.Add(3);

            Cardapio cardapio = new Cardapio();
            var carne = cardapio.ObterCardapioIngredientes()
                .Where(ingrediente => ingrediente.IngredienteId == 3)
                .FirstOrDefault().Valor;

            var alface = cardapio.ObterCardapioIngredientes()
                .Where(ingrediente => ingrediente.IngredienteId == 1)
                .FirstOrDefault().Valor;


            var precoFinal = (alface + carne) - ((alface + carne) * 0.1m);


            CalculoPrecoLanche calculo = new CalculoPrecoLanche();
            Assert.AreEqual(precoFinal, calculo.CalcularPrecoDoLanche(ids));
        }


        [TestMethod()]
        public void CalcularPrecoDoLancheComTodasPromocoes()
        {
            List<int> ids = new List<int>();
            ids.Add(1);
            ids.Add(3);
            ids.Add(3);
            ids.Add(3);
            ids.Add(5);
            ids.Add(5);
            ids.Add(5);
            ids.Add(3);
            ids.Add(3);
            ids.Add(3);
            ids.Add(5);
            ids.Add(5);
            ids.Add(5);


            Cardapio cardapio = new Cardapio();
            var carne = cardapio.ObterCardapioIngredientes()
                .Where(ingrediente => ingrediente.IngredienteId == 3)
                .FirstOrDefault().Valor;

            var alface = cardapio.ObterCardapioIngredientes()
                .Where(ingrediente => ingrediente.IngredienteId == 1)
                .FirstOrDefault().Valor;

            var queijo = cardapio.ObterCardapioIngredientes()
                .Where(ingrediente => ingrediente.IngredienteId == 5)
                .FirstOrDefault().Valor;

            var precoFinal = (queijo * 4) + (carne * 4) + alface;

            precoFinal -= precoFinal * 0.1m;

            CalculoPrecoLanche calculo = new CalculoPrecoLanche();
            Assert.AreEqual(precoFinal, calculo.CalcularPrecoDoLanche(ids));
        }

        [TestMethod()]
        public void CalcularPrecoDoLancheNaoLight()
        {
            List<int> ids = new List<int>();
            ids.Add(1);
            ids.Add(2);
            ids.Add(3);

            Cardapio cardapio = new Cardapio();
            var carne = cardapio.ObterCardapioIngredientes()
                .Where(ingrediente => ingrediente.IngredienteId == 3)
                .FirstOrDefault().Valor;

            var alface = cardapio.ObterCardapioIngredientes()
                .Where(ingrediente => ingrediente.IngredienteId == 1)
                .FirstOrDefault().Valor;

            var bacon = cardapio.ObterCardapioIngredientes()
                .Where(ingrediente => ingrediente.IngredienteId == 2)
                .FirstOrDefault().Valor;

            var precoFinal = bacon + carne  + alface;


            CalculoPrecoLanche calculo = new CalculoPrecoLanche();
            Assert.AreEqual(precoFinal, calculo.CalcularPrecoDoLanche(ids));
        }
    }
}