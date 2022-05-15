using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ph.Domain.Enums
{
    public enum TipoFormaPagamento
    {
        Dinheiro = 1,
        CartaoCredito = 2,
        CartaoDebito = 3,
        Pix = 4,
        Transferencia = 5,
        PagamentoDigital = 6,
    }
}
