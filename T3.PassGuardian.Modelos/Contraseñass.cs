using System.ComponentModel.DataAnnotations;

public class CONTRASEÑASS{
    [Key]
    public int IDContraseña { get; set; }
    public int IDCuenta { get; set; }
    public string? ContraseñaEncriptada { get; set; }
    public DateTime UltimaModificacion { get; set; }
    public DateTime FechaExpiracion { get; set; }
    public int PuntuacionFortalezaContraseña { get; set; }
    //public text PreguntasSeguridad { get; set }
}