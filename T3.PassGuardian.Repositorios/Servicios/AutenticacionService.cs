using Microsoft.EntityFrameworkCore;

public class AutenticacionService : IAutenticacion
{
    public async Task<bool> ActualizarAutenticacion(AUTENTICACION autenticacion)
    {
        using (var conexon = new SeguridadDBContext())
{
    var consulta = await(from  c in conexon.AUTENTICACION
    where c.IDAutenticacion == autenticacion.IDAutenticacion select c).FirstOrDefaultAsync();
    if (consulta!=null)
    {
        consulta.IDUsuario = autenticacion.IDUsuario;
        consulta.MetodoAutenticacion = autenticacion.MetodoAutenticacion;
        consulta.DatosAutenticacion = autenticacion.DatosAutenticacion;
       await conexon.SaveChangesAsync();
        
        return await Task.FromResult(true);
    }
     return await Task.FromResult(false);
}
       
    }

    public async Task<List<AUTENTICACION>> ConsultarAutenticacion()
    {
    using (var conexion = new SeguridadDBContext())
    {
        var consulta = await(from c in conexion.AUTENTICACION select c).ToListAsync();
        return consulta??new List<AUTENTICACION>();;
    }
    }

    public async Task<bool> EliminarAutenticacion(int IdAutenticacion)
    {
using (var conexon = new  SeguridadDBContext())
{
    var consulta = await(from  c in conexon.AUTENTICACION
    where c.IDAutenticacion == IdAutenticacion select c).FirstOrDefaultAsync();
    if (consulta!=null)
    {
        conexon.AUTENTICACION.Remove(consulta);
         await  conexon.SaveChangesAsync();
      
        return await Task.FromResult(true);
    }
     return await Task.FromResult(false);
}

      
    }

    public async Task<bool> GuardarAutenticacion(AUTENTICACION autenticacion)
    {
       using (var conexion = new  SeguridadDBContext())
       {
        conexion.AUTENTICACION.Add(autenticacion);
       await conexion.SaveChangesAsync();
        return await Task.FromResult(true);
       }
    }
}