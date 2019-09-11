using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.Model.Base
{
    public class GenericEntity : IGenericEntity
    {
        // [Key] - Data Annotation que define Codigo como chave primária
        [Key]
        public int Codigo { get; set; }

        public bool Ativo { get; set; }
    }
}
