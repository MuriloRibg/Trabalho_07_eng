using System.ComponentModel.DataAnnotations;
using Atividade_07.Models.Enums;

namespace Atividade_07.Models
{
    public class Servico
    {
        [Key]
        [Required]
        public long Id { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public TipoServico TipoServico { get; private set; }
        public Empregador Empregador { get; private set; }
        public Trabalhador Trabalhador { get; private set; }
        public Endereco EnderecoContrato { get; private set; }
        public Pagamento Pagamento { get; private set; }

        public Servico(DateTime dataInicio, DateTime dataFim, TipoServico tipoServico, Empregador empregador, Trabalhador trabalhador, Endereco enderecoContrato, Pagamento pagamento)
        {
            SetDataInicio(dataInicio);
            SetDataFim(dataFim);
            SetTipoServico(tipoServico);
            SetEmpregador(empregador);
            SetTrabalhador(trabalhador);
            SetEnderecoContrato(enderecoContrato);
            SetPagamento(pagamento);
        }

        public void SetDataInicio(DateTime dataInicio) => DataInicio = dataInicio;
        public void SetDataFim(DateTime dataFim) => DataFim = dataFim;
        public void SetTipoServico(TipoServico tipoServico) => TipoServico = tipoServico;
        public void SetEnderecoContrato(Endereco endereco) => EnderecoContrato = endereco;
        public void SetPagamento(Pagamento pagamento) => Pagamento = pagamento;
        public void SetEmpregador(Empregador empregador) => Empregador = empregador;
        public void SetTrabalhador(Trabalhador trabalhador) => Trabalhador = trabalhador;
    }
}
