using System.ComponentModel.DataAnnotations;

namespace Atividade_07.Models
{
    public class Multa
    {
        [Key]
        [Required]
        public long Id { get; private set; }
        public string Observacao { get; private set; }
        public Usuario Usuario { get; private set; }
        public Pagamento Pagamento { get; private set; }
        public Administrador Aplicador { get; private set; }

        public Multa(string observacao, Usuario usuario, Pagamento pagamento, Administrador aplicador)
        {
            SetObservacao(observacao);
            SetUsuario(usuario);
            SetPagamento(pagamento);
            SetAplicador(aplicador);
        }

        public void SetObservacao(string observacao) => Observacao = observacao;
        public void SetUsuario(Usuario usuario) => Usuario = usuario;
        public void SetPagamento(Pagamento pagamento) => Pagamento = pagamento;
        public void SetAplicador(Administrador aplicador) => Aplicador = aplicador;
    }

}
