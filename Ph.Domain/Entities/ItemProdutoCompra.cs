using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ph.Domain.Entities
{
    public class ItemProdutoCompra : ItemProduto
    {
        public Compra Compra { get; set; }
    }
}
