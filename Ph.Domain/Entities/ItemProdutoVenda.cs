using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ph.Domain.Entities
{
   public  class ItemProdutoVenda : ItemProduto
    {
        public Venda Venda { get; set; }
    }
}
