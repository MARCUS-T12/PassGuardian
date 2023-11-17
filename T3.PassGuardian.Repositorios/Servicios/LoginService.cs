using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

public class LoginService: ILogin{

  public async Task<USUARIOS> IniciarSesion(User user)
  {
    using (var conexion = new SeguridadDBContext()){
      
      var Resultado = await (from c in conexion.USUARIOS
      where c.NombreUsuario == user.Usuario
      && c.HashContraseña == user.PassWord
      select c).FirstOrDefaultAsync();

      if(Resultado != null){
        return Resultado;
      }else{
        return new USUARIOS();
      }
    }
  }
}

    // public async Task<bool> IniciarSesion(User user)
    // {
    
//    bool Resultado=false;
//    //Implemetnacion de la base de datos
//    //         //Logica a la conexion a las bases de datos
//         // var Resultado=new Empleados();
//         using (var sqlConnection=new SqlConnection(ContextoConfiguracion.CadenaConexion))
//         {
//            try
//            {
//             var Comando=new SqlCommand();
//             Comando.Connection=sqlConnection;
//             Comando.CommandText="[dbo].[Autentificar]";
//             Comando.CommandType=System.Data.CommandType.StoredProcedure;
//             Comando.Parameters.AddWithValue("@Usuario",user.Correo);
//             Comando.Parameters.AddWithValue("@Password",user.PassWord);
            
//             await sqlConnection.OpenAsync();
//             var lectura=await Comando.ExecuteReaderAsync();
//             if(lectura.HasRows)
//             {
//                 if(lectura.Read())
//                 {
//               Resultado=true;
  
//                 }
//             }else{
//               Resultado=false;
//             }

            
//            }
//            catch (System.Exception ex)
//            {
//             Resultado=false;
          
         
//            } 
//         }

//  return Resultado;
//    return true;
