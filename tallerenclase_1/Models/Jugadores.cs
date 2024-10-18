using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tallerenclase_1.Models
{
    public class Jugadores
    {
        
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
         public Equipo Equipo { get; set; }
        [ForeignKey("nombre")]
        public int Edad {  get; set; }
        public string Posicion {  get; set; }
       

    }
}
