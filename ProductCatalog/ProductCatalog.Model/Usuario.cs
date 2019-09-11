using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.Model
{
    public class Usuario : Base.GenericEntity
    {
        // [Required] - Data Annotation que determina que um campo é de preenchimento obrigatório (NOT NULL)
        // [StringLength(xx)] - Data Annotation que determina o tamanho máximo em carateres
        // [DataType(DataType.EmailAddress)] - Data Annotation que exige que o dado esteja no formato de um E-mail
        // [DataType(DataType.Password)] - Data Annotation que indica a renderização de um campo do tipo Senha (password)

        [Required, StringLength(50)]
        public string Nome { get; set; }

        [Required, StringLength(100), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, StringLength(32), DataType(DataType.Password)]
        public string Senha { get; set; }

        //Campo adicionado após a criação do Banco de Dados
        [DataType(DataType.PhoneNumber), StringLength(20)]
        public string Telefone { get; set; }
    }
}
