using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductCatalog.Model
{
    public class Produto : Base.GenericEntity
    {
        //Atributo Table - Permite determinar nome da Tabela vinculada à Model [Table("Produtos")]
        
        // [Required] - Data Annotation que determina que um campo é de preenchimento obrigatório (NOT NULL)
        // [DataType(DataType.MultilineText)] - Data Annotation que determina a renderização de um campo texto multilinha
        // [DataType(DataType.Currency)] - Data Annotation que determina que o campo será renderizado como representação de Moeda
        // [StringLength(xx)] - Data Annotation que determina o tamanho máximo em carateres
        // [ForeignKey("xxx")] - Data Annotation que cria o FK de uma property xxx


        [Required, StringLength(100)]
        public string Titulo { get; set; }

        [Required, DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        [Required, DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        [Required, StringLength(100)]
        public string Imagem { get; set; }

        // Associação com Categoria (Relacionamento)
        public virtual Categoria Categoria { get; set; }

        [ForeignKey("Categoria")]
        public int CategoriaCodigo { get; set; }

        public decimal Estoque { get; set; }
    }
}
