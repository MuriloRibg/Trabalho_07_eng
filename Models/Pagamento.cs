using System.ComponentModel.DataAnnotations;
using Atividade_07.Models.Enums;

namespace Atividade_07.Models
{
    public class Pagamento
    {
        [Key]
        [Required]
        public long Id { get; private set; }
        public TipoPagamento TipoPagamento { get; private set; }
        public decimal Valor { get; private set; }

        public Pagamento(TipoPagamento tipoPagamento, decimal valor)
        {
            SetTipoPagamento(tipoPagamento);
            SetValor(valor);
        }

        public void SetTipoPagamento(TipoPagamento tipoPagamento) => TipoPagamento = tipoPagamento;
        public void SetValor(decimal valor) => Valor = valor;
    }

}
