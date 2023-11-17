public interface IContraseñass
{
    Task<bool> GuardarContraseña(CONTRASEÑASS contraseñass);
        Task<bool>ActualizarContraseña(CONTRASEÑASS contraseñass);
            Task<bool> EliminarContraseña(int IdContraseña);
                Task<List<CONTRASEÑASS>> ConsultarContraseña();
                 
}