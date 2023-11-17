using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("Api/Seguridad")]
public class AutenticacionController:ControllerBase
{
    IAutenticacion _AutenticacionService;
    public AutenticacionController(IAutenticacion autenticacion)
    {
      
      _AutenticacionService = autenticacion;
        
    }

[HttpGet("ObtenerAutenticacion")]
    public IActionResult ObtenerAutenticacion()
    {
        var resultado =_AutenticacionService.ConsultarAutenticacion();
        return Ok(resultado);

    }

    [HttpPost("RegistrarAutenticacion")]
    public async  Task<IActionResult> GuardarAutenticacion(AUTENTICACION autenticacion)
    {
var Resultado= await _AutenticacionService.GuardarAutenticacion(autenticacion);
    return Ok(Resultado);
    }
       [HttpPut("ActualizarAutenticacion")]
    public async  Task<IActionResult> ActualizarAutenticacion(AUTENTICACION autenticacion)
    {
var Resultado= await _AutenticacionService.ActualizarAutenticacion(autenticacion);
    return Ok(Resultado);
    }
          [HttpDelete("EliminarAutenticacion")]
    public async  Task<IActionResult> EliminarAutenticacion(int IdAutenticacion)
    {
var Resultado= await _AutenticacionService.EliminarAutenticacion(IdAutenticacion);
    return Ok(Resultado);
    }

}