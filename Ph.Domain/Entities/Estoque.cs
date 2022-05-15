using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ph.Domain.Entities
{
    public class Estoque
    {
        public long Id { get; set; }
        public int Quantidade { get; protected set; }
        public string Localizacao { get; set; }
        public Produto Produto { get; set; }

        public void AtribuirQuantidade(int quantidade)
        {
            this.Quantidade = quantidade;
        }

        public void Incrementar(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void Decrementar(int quantidade)
        {
            Quantidade -= quantidade;
        }
    }
}
