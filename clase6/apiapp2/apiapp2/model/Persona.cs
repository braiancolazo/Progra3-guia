using System.ComponentModel.DataAnnotations.Schema;

namespace apiapp2.model
{
    [Table("personas")]
    public class Persona
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int IdCategoria { get; set; }

        [ForeignKey("IdCategoria")]
        public Categoria Categoria { get; set; }


    }
}
