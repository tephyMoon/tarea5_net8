using System.ComponentModel.DataAnnotations;
namespace api_empresa.Models;

public class Clientes {

[Key]
    public Int32 id_cliente {get;set;}
    public string? nombres { get; set; }
    public string? apellidos { get; set; }
    public string? direccion { get; set; }
    public string? telefono { get; set; }
    public DateTime? fecha_nacimiento { get; set; }

}