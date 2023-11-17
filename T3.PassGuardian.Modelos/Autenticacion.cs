using System.ComponentModel.DataAnnotations;

public class AUTENTICACION{
    [Key]
    public int IDAutenticacion { get; set; }
    public int IDUsuario { get; set; }
    public string? MetodoAutenticacion { get; set; }
    public string? DatosAutenticacion { get; set; }
    //public text FechaCreacion { get; set; }
}