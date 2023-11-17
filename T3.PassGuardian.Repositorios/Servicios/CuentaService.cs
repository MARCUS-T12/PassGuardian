using Microsoft.EntityFrameworkCore;

public class CuentaService : ICuentas
{
    public async Task<bool> ActualizarCuenta(CUENTAS cuentas)
    {
        using (var conexon = new SeguridadDBContext())
{
    var consulta=await(from  c in conexon.CUENTAS
    where c.IDCuenta == cuentas.IDCuenta select c).FirstOrDefaultAsync();
    if (consulta!=null)
    {
        consulta.IDUsuario = cuentas.IDUsuario;
        consulta.SitioWebOServicio = cuentas.SitioWebOServicio;
        consulta.URLSitioWeb = cuentas.URLSitioWeb;
        consulta.FechaCreacion = cuentas.FechaCreacion;
        consulta.UltimaModificacion = cuentas.UltimaModificacion;
        consulta.NombreUsuarioOEmail = cuentas.NombreUsuarioOEmail;
       await conexon.SaveChangesAsync();
        
        return await Task.FromResult(true);
    }
     return await Task.FromResult(false);
}
       
    }

    public async Task<List<CUENTAS>> ConsultarCuenta()
    {
    using (var conexion = new SeguridadDBContext())
    {
        var consulta = await(from c in conexion.CUENTAS select c).ToListAsync();
        return consulta??new List<CUENTAS>();;
    }
    }

    public async Task<bool> EliminarCuenta(int IdCuenta)
    {
using (var conexon = new  SeguridadDBContext())
{
    var consulta = await(from  c in conexon.CUENTAS
    where c.IDCuenta == IdCuenta select c).FirstOrDefaultAsync();
    if (consulta!=null)
    {
        conexon.CUENTAS.Remove(consulta);
         await  conexon.SaveChangesAsync();
      
        return await Task.FromResult(true);
    }
     return await Task.FromResult(false);
}

      
    }

    public async Task<bool> GuardarCuenta(CUENTAS categorias)
    {
       using (var conexion = new  SeguridadDBContext())
       {
        conexion.CUENTAS.Add(categorias);
       await conexion.SaveChangesAsync();
        return await Task.FromResult(true);
       }
    }
}