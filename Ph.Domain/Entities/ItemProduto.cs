using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ph.Domain.Entities
{
    public class ItemProduto
    {
        public long Id { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }
    }
}
