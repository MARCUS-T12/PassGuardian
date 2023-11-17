using Microsoft.EntityFrameworkCore;

public class ContraseñaService : IContraseñass
{
    public async Task<bool> ActualizarContraseña(CONTRASEÑASS contraseñass)
    {
        using (var conexon = new SeguridadDBContext())
{
    var consulta = await(from  c in conexon.CONTRASEÑASS
    where c.IDContraseña == contraseñass.IDContraseña select c).FirstOrDefaultAsync();
    if (consulta!=null)
    {
        consulta.IDCuenta = contraseñass.IDCuenta;
        consulta.UltimaModificacion = contraseñass.UltimaModificacion;
        consulta.FechaExpiracion = contraseñass.FechaExpiracion;
        consulta.PuntuacionFortalezaContraseña = contraseñass.PuntuacionFortalezaContraseña;
        consulta.ContraseñaEncriptada = contraseñass.ContraseñaEncriptada;
       await conexon.SaveChangesAsync();
        
        return await Task.FromResult(true);
    }
     return await Task.FromResult(false);
}
       
    }

    public async Task<List<CONTRASEÑASS>> ConsultarContraseña()
    {
    using (var conexion = new SeguridadDBContext())
    {
        var consulta = await(from c in conexion.CONTRASEÑASS select c).ToListAsync();
        return consulta??new List<CONTRASEÑASS>();;
    }
    }

    public async Task<bool> EliminarContraseña(int IdContraseña)
    {
using (var conexon = new  SeguridadDBContext())
{
    var consulta = await(from  c in conexon.CONTRASEÑASS
    where c.IDContraseña == IdContraseña select c).FirstOrDefaultAsync();
    if (consulta!=null)
    {
        conexon.CONTRASEÑASS.Remove(consulta);
         await  conexon.SaveChangesAsync();
      
        return await Task.FromResult(true);
    }
     return await Task.FromResult(false);
}

      
    }

    public async Task<bool> GuardarContraseña(CONTRASEÑASS contraseñass)
    {
       using (var conexion = new  SeguridadDBContext())
       {
        conexion.CONTRASEÑASS.Add(contraseñass);
       await conexion.SaveChangesAsync();
        return await Task.FromResult(true);
       }
    }
}