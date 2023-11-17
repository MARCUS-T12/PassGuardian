using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("Api/Seguridad")]
public class ContraseñassController:ControllerBase
{
    IContraseñass _ContraseñassService;
    public ContraseñassController(IContraseñass contraseñass)
    {
      
      _ContraseñassService = contraseñass;
        
    }

[HttpGet("ObtenerContraseñass")]
    public IActionResult ObtenerCuentas()
    {
        var resultado =_ContraseñassService.ConsultarContraseña();
        return Ok(resultado);

    }

    [HttpPost("RegistrarContraseña")]
    public async  Task<IActionResult> GuardarContraseña(CONTRASEÑASS contraseñass)
    {
var Resultado= await _ContraseñassService.GuardarContraseña(contraseñass);
    return Ok(Resultado);
    }
       [HttpPut("ActualizarContraseña")]
    public async  Task<IActionResult> ActualizarContraseña(CONTRASEÑASS contraseñass)
    {
var Resultado= await _ContraseñassService.ActualizarContraseña(contraseñass);
    return Ok(Resultado);
    }
          [HttpDelete("EliminarContraseña")]
    public async  Task<IActionResult> EliminarContraseña(int IdContraseña)
    {
var Resultado= await _ContraseñassService.EliminarContraseña(IdContraseña);
    return Ok(Resultado);
    }

}