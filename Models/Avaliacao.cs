using System.ComponentModel.DataAnnotations;

namespace Atividade_07.Models
{
    public class Avaliacao
    {
        [Key]
        [Required]
        public long Id { get; private set; }
        public string Descricao { get; private set; }
        public int Nota { get; private set; }
        public Usuario Autor { get; private set; }
        public Usuario Destinatario { get; private set; }

        public Avaliacao(string descricao, int nota, Usuario autor, Usuario destinatario)
        {
            SetDescricao(descricao);
            SetNota(nota);
            SetAutor(autor);
            SetDestinatario(destinatario);
        }

        public void SetDescricao(string descricao) => Descricao = descricao;
        public void SetNota(int nota) => Nota = nota;
        public void SetAutor(Usuario autor) => Autor = autor;
        public void SetDestinatario(Usuario destinatario) => Destinatario = destinatario;
    }
}
