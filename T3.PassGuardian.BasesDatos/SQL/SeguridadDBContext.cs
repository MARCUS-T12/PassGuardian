using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;


    public partial class SeguridadDBContext:DbContext{

    public virtual DbSet<USUARIOS> USUARIOS {get;set;}
    public virtual DbSet<CUENTAS> CUENTAS {get;set;}
    public virtual DbSet<CONTRASEÑASS> CONTRASEÑASS {get;set;}
    public virtual DbSet<AUTENTICACION> AUTENTICACION {get;set;}

    
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     if (!optionsBuilder.IsConfigured)
    //     {
    //         string cadenaConexion = ContextoConfiguracion.CadenaConexion ?? "cadena_conexion_predeterminada";
    //         if (cadenaConexion != null){
    //             optionsBuilder.UseMySQL(cadenaConexion, builder => {
    //             builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
    //         });
    //         }
    //     }

    //     base.OnConfiguring(optionsBuilder);
    // }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ContextoConfiguracion.CadenaConexion, builder=> {
                    builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
                });
            }

        base.OnConfiguring(optionsBuilder); 
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
modelBuilder.Entity<AUTENTICACION>().HasKey(x=>x.IDAutenticacion);
modelBuilder.Entity<CONTRASEÑASS>().HasKey(x=>x.IDContraseña);
modelBuilder.Entity<CUENTAS>().HasKey(x=>x.IDCuenta);
modelBuilder.Entity<USUARIOS>().HasKey(x=>x.IDUsuario);
    }
}