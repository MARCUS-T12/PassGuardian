using System.ComponentModel.DataAnnotations;

public class CUENTAS{
    [Key]
    public int IDCuenta { get; set; }
    public int IDUsuario { get; set; }
    public string? SitioWebOServicio { get; set;}
    public string? URLSitioWeb { get; set; }
    public string? NombreUsuarioOEmail { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime UltimaModificacion { get; set; }
    //public text Notas { get; set; }
}