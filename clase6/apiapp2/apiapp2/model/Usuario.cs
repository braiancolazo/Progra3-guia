using System.ComponentModel.DataAnnotations.Schema;

namespace apiapp2.model
{
    [Table("usuarios")]
    public class Usuario
    {
        public int id { get; set; }
        public string NombreUsu { get; set; }
        public string Apellido { get; set; }
     
    }
}
