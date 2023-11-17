public interface IAutenticacion
{
    Task<bool> GuardarAutenticacion(AUTENTICACION autenticacion);
        Task<bool>ActualizarAutenticacion(AUTENTICACION autenticacion);
            Task<bool> EliminarAutenticacion(int IdAutenticacion);
                Task<List<AUTENTICACION>> ConsultarAutenticacion();
                 
}