using Ph.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Ph.Test.Entity
{
    public class EstoqueTest
    {
        [Fact]
        public void DeveIncrementarQuantidadeEmEstoque()
        {
            var estoque = new Estoque();
            estoque.Id = 2;
            estoque.Produto = new Produto
            {
                Id = 1,
                Descricao = "Amortecedor",
                CodigoExterno = "GP4880",
                CodigoInterno = "875714",
                ValorUnitario = 150.10M
            };
            estoque.AtribuirQuantidade(2);

            estoque.Incrementar(5);

            Assert.True(estoque.Quantidade == 7);
        }
    }
}
