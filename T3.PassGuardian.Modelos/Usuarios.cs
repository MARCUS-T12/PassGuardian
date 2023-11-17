using System.ComponentModel.DataAnnotations;

public class USUARIOS
{
    [Key]
    public int IDUsuario { get; set; }
    public string? NombreUsuario { get; set; }
    public string? HashContraseña { get; set; }
    public string? CorreoElectronico { get; set; }
    public DateTime FechaRegistro { get; set; }
    public DateTime UltimoInicio { get; set; }
}