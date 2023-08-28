using ApiCalc.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiCalc.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiCalcController : ControllerBase
    {
        private readonly IApiCalcService _apiCalcService;

        public ApiCalcController(IApiCalcService apiCalcService)
        {
            _apiCalcService = apiCalcService;
        }

        [HttpGet("calcularCDB")]
        public ActionResult<IApiCalcResultado> Calc(decimal valor, int prazo)
        {
            var resultado = _apiCalcService.Calc(valor, prazo);
            return Ok(resultado);
        }
    }
}
