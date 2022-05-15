using Ph.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ph.Domain.Entities
{
    public class Fornecedor
    {
        public long Id { get; set; }
        public string RazaoSocial { get; set; }
        public string CnpjCpf { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public Email Email { get; set; }
        public Endereco Endereco { get; set; }
    }
}
