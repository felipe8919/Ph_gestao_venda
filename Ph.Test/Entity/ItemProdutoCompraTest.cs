using Ph.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Ph.Test.Entity
{

    public class ItemProdutoCompraTest
    {
        [Fact]
        public void DeveSomarItensProdutoCompra()
        {
            Compra compra = MocarCompra();

            Assert.Equal(1540.00M, compra.ValorTotal);
        }

        private static Compra MocarCompra()
        {
            var compra = new Compra
            {
                Id = 1,
                NumeroNotaFiscal = 1234,
                OrdemDeCompra = 123,
                DataEntrada = new DateTime(2022, 5, 22)
            };

            compra.AtribuirFornecedor(CriarFornecedor());

            var produtoA = CriarProduto(1, "Cabo de vela", "8055216", "STC30", 150.00M);
            var produtoB = CriarProduto(2, "Calço motor", "8212545", "SP2545", 250.00M);
            var produtoC = CriarProduto(3, "Kit amortecedor", "7254126", "0112225", 80.00M);


            // TODO REFATORAR INSTÂNCIAS CRIANDO MÉTODOS
            ItemProdutoCompra itemProduto1 = InserirItemProdutoCompra(1, 150.00M, 2, produtoA);
            ItemProdutoCompra itemProduto2 = InserirItemProdutoCompra(2, 250.00M, 4, produtoB);
            ItemProdutoCompra itemProduto3 = InserirItemProdutoCompra(3, 80.00M, 3, produtoC);

            var listaCompra = new List<ItemProdutoCompra> { itemProduto1, itemProduto2, itemProduto3 };

            compra.AtribuirItensProdutos(listaCompra);
            return compra;
        }

        private static ItemProdutoCompra InserirItemProdutoCompra(long id, decimal valorUnitario, int quantidade, Produto produto)
        {
            return new ItemProdutoCompra
            {
                Id = id,
                ValorUnitario = valorUnitario,
                Quantidade = quantidade,
                Produto = produto
            };
        }
                
        private static Produto CriarProduto(long id, string descricao,
            string codigoInterno, string codigoExterno, decimal valorUnitario)
        {
            return new Produto
            {
                Id = id,
                Descricao = descricao,
                CodigoInterno = codigoInterno,
                CodigoExterno = codigoExterno,
                ValorUnitario = valorUnitario
            };
        }

        private static Fornecedor CriarFornecedor()
        {
            var fornecedor = new Fornecedor();
            fornecedor.Id = 1595;
            fornecedor.RazaoSocial = "Ph software";
            fornecedor.CnpjCpf = "123456789";
            return fornecedor;
        }

        [Fact]
        public void DeveExistirFornecedorNaCompra()
        {
            Compra compra = MocarCompra();
            Assert.NotNull(compra.Fornecedor);
        }

        [Fact]
        public void DeveConterAoMenosUmItemDeProduto()
        {
            Compra compra = MocarCompra();
            Assert.True(compra.ContemPeloMenosUmItemProduto);
        }

        [Fact]
        public void NaoDeveConterItemDeProduto()
        {
            Compra compra = MocarCompra();
            compra.RemoverTodosItensDeProduto();
            Assert.False(compra.ContemPeloMenosUmItemProduto);
        }
    }
}
