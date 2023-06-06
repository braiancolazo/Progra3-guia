using System.ComponentModel.DataAnnotations.Schema;

namespace apiapp2.model
{
    [Table("categorias")]
    public class Categoria
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        
    }
}
