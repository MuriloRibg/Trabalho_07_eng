using System.ComponentModel.DataAnnotations;

namespace Atividade_07.Models
{
    public class Administrador
    {
        [Key]
        [Required]
        public long Id { get; private set; }
        public string Nome { get; private set; }
        public string SegundoNome { get; private set; }
        public string Email { get; private set; }
        public string Documento { get; private set; }
        public string Telefone { get; private set; }

        public Administrador(string nome, string segundoNome, string email, string documento, string telefone)
        {
            SetNome(nome);
            SetSegundoNome(segundoNome);
            SetEmail(email);
            SetDocumento(documento);
            SetTelefone(telefone);
        }

        public void SetNome(string nome) => Nome = nome;
        public void SetSegundoNome(string segundoNome) => SegundoNome = segundoNome;
        public void SetEmail(string email) => Email = email;
        public void SetDocumento(string documento) => Documento = documento;
        public void SetTelefone(string telefone) => Telefone = telefone;
    }

}
