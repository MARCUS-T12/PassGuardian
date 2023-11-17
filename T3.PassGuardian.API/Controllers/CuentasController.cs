using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("Api/Seguridad")]
public class CuentasController:ControllerBase
{
    ICuentas _CuentasService;
    public CuentasController(ICuentas cuentas)
    {
      
      _CuentasService=cuentas;
        
    }

[HttpGet("ObtenerCuentas")]
    public IActionResult ObtenerCuentas()
    {
        var resultado=_CuentasService.ConsultarCuenta();
        return Ok(resultado);

    }

    [HttpPost("RegistrarCuenta")]
    public async  Task<IActionResult> GuardarCuenta(CUENTAS cuentas)
    {
var Resultado= await _CuentasService.GuardarCuenta(cuentas);
    return Ok(Resultado);
    }
       [HttpPut("ActualizarCuenta")]
    public async  Task<IActionResult> ActualizarCuenta(CUENTAS cuentas)
    {
var Resultado= await _CuentasService.ActualizarCuenta(cuentas);
    return Ok(Resultado);
    }
          [HttpDelete("EliminarCuenta")]
    public async  Task<IActionResult> EliminarCuenta(int IdCuenta)
    {
var Resultado= await _CuentasService.EliminarCuenta(IdCuenta);
    return Ok(Resultado);
    }

}