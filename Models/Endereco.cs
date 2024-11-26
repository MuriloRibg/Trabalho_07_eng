using System.ComponentModel.DataAnnotations;

namespace Atividade_07.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public long Id { get; private set; }
        public string Rua { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string CEP { get; private set; }

        public Endereco(string rua, string cidade, string estado, string cep)
        {
            SetRua(rua);
            SetCidade(cidade);
            SetEstado(estado);
            SetCEP(cep);
        }

        public void SetRua(string rua) => Rua = rua;
        public void SetCidade(string cidade) => Cidade = cidade;
        public void SetEstado(string estado) => Estado = estado;
        public void SetCEP(string cep) => CEP = cep;
    }

}
