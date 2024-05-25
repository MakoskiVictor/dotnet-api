using System;
using System.Collections.Generic; // De acá traigo List
using System.ComponentModel.DataAnnotations.Schema; // Trae el Column y se usa para especificar cómo se debe mapear una propiedad en la base de datos
using System.Linq;
using System.Threading.Tasks;

namespace aspnetwebapi.Models
{
  public class Stock
  {
    public int id { get; set; }
    public string Symbol { get; set; } = string.Empty;
    // stryng.Empty inicializa con una cadena vacía("") 
    //para evitar que el valor sea null en caso de no recibir parámetros
    public string CompanyName { get; set; } = string.Empty;
    [Column(TypeName = "decimal(18,2)")]
    // El atributo Column se utiliza para especificar detalles de la columna en la base de datos.
    // "decimal(18,2)" indica que la columna será de tipo decimal con una precisión total de 18 dígitos, de los cuales 2 son decimales.
    public decimal Purchase { get; set; }
    [Column(TypeName = "decimal(18,2)")]
    public decimal LastDiv { get; set; }
    public string Industry { get; set; } = string.Empty;
    public long MarketCap { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();
    // = new List<Comment>();: Inicializa la propiedad Comments con una nueva instancia 
    // de List<Comment>. Esto significa que cuando se crea una instancia de la clase que 
    // contiene esta propiedad, Comments no será null; en cambio, será una lista vacía 
    // de Comment. (Evitamos el NullReferenceException)
  }
}