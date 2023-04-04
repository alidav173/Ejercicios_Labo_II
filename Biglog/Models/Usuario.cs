using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biglog.Models
{
  public class Usuario
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string User { get; set; }
    public string Password { get; set; }
    public int Edad { get; set; }
    [EnumDataType(typeof(Sexo))]
    public Sexo SexoEscogido { get; set; }
  }
}
