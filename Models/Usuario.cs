
using System.ComponentModel.DataAnnotations;
using Atividade_07.Models.Enums;

namespace Atividade_07.Models
{

    public class Usuario
    {
        [Key]
        [Required]
        public long Id { get; private set; }
        public string Nome { get; private set; }
        public string SegundoNome { get; private set; }
        public string Email { get; private set; }
        public string Documento { get; private set; }
        public string Telefone { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public Sexo Sexo { get; private set; }
        public Ativo Ativo { get; private set; }
        public List<Avaliacao> Avaliacoes { get; private set; }

        public Usuario(string nome, string segundoNome, string email, string documento, string telefone, DateTime dataNascimento, Sexo sexo, Ativo ativo)
        {
            SetNome(nome);
            SetSegundoNome(segundoNome);
            SetEmail(email);
            SetDocumento(documento);
            SetTelefone(telefone);
            SetDataNascimento(dataNascimento);
            SetSexo(sexo);
            SetAtivo(ativo);
            Avaliacoes = [];
        }
        public void SetNome(string nome) => Nome = nome;
        public void SetSegundoNome(string segundoNome) => SegundoNome = segundoNome;
        public void SetEmail(string email) => Email = email;
        public void SetDocumento(string documento) => Documento = documento;
        public void SetTelefone(string telefone) => Telefone = telefone;
        public void SetDataNascimento(DateTime dataNascimento) => DataNascimento = dataNascimento;
        public void SetSexo(Sexo sexo) => Sexo = sexo;
        public void SetAtivo(Ativo ativo) => Ativo = ativo;
    }

    public class Empregador : Usuario
    {
        public List<Avaliacao> AvaliacoesEmpregador { get; set; } = [];
        public Empregador(string nome, string segundoNome, string email, string documento, string telefone, DateTime dataNascimento, Sexo sexo, Ativo ativo)
        : base(nome, segundoNome, email, documento, telefone, dataNascimento, sexo, ativo)
        {
            AvaliacoesEmpregador = [];
        }
    }

    public class Trabalhador : Usuario
    {
        public DateTime DataInicioExpediente { get; set; }
        public DateTime DataFimExpediente { get; set; }
        public List<Avaliacao> AvaliacoesTrabalhador { get; set; } = [];

        public Trabalhador(string nome, string segundoNome, string email, string documento, string telefone, DateTime dataNascimento, Sexo sexo, Ativo ativo,
        DateTime dataInicioExpediente, DateTime dataFimExpediente)
        : base(nome, segundoNome, email, documento, telefone, dataNascimento, sexo, ativo)
        {
            SetDataInicioExpediente(dataInicioExpediente);
            SetDataFimExpediente(dataFimExpediente);
            AvaliacoesTrabalhador = new List<Avaliacao>();
        }

        public void SetDataInicioExpediente(DateTime dataInicio) => DataInicioExpediente = dataInicio;
        public void SetDataFimExpediente(DateTime dataFim) => DataFimExpediente = dataFim;
    }

}
