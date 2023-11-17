public interface ICuentas
{
    Task<bool> GuardarCuenta(CUENTAS cuentas);
        Task<bool>ActualizarCuenta(CUENTAS cuentas);
            Task<bool> EliminarCuenta(int IdCuenta);
                Task<List<CUENTAS>> ConsultarCuenta();
                 
}