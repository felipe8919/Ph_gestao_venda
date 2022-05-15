using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ph.Domain.Entities
{
   public class Produto
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public string CodigoInterno { get; set; }
        public string CodigoExterno { get; set; }
        public decimal ValorUnitario { get; set; }
        

    }
}
