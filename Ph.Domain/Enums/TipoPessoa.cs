using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ph.Domain.Enums
{
    public enum TipoPessoa
    {
        [Description("Pessoa Física")]
        PessoaFisica = 1,
        [Description("Pessoa Jurídica")]
        PessoaJurica = 2 
    }
}
