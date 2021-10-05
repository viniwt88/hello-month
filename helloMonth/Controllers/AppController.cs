using helloMonth.AppServices;
using Microsoft.AspNetCore.Mvc;

namespace helloMonth.Controllers
{
    [Route("api/ola-dia")]
    [ApiController]
    public class AppController : ControllerBase
    {
        [HttpGet]
        [Route("obter-dia/")]
        public IActionResult MensagemDoDia(int dia, int mes, int ano)
        {

            var message = AppService.ObterDiaDaSemana(dia, mes, ano);

            if (string.IsNullOrEmpty(message))
            {
                return BadRequest(new
                {
                    success = false,
                    message = "Esse dia não foi reconhecido!"
                });
            }
            return Ok(new
            {
                success = true,
                message
            });
        }
    }
}
