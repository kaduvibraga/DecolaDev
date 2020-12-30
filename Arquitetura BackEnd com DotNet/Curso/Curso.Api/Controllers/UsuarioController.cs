using Curso.Api.Filters;
using Curso.Api.Models;
using Curso.Api.Models.Usuario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso.Api.Controllers
{
    [Route("api/v1/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        /// <summary>
        /// teste
        /// </summary>
        /// <param name="loginViewModel">View model do login</param>
        /// <returns></returns>
       [SwaggerResponse(statusCode: 200, description :"Sucesso ao autenticar", Type = typeof(LoginViewModelInput))]
       [SwaggerResponse(statusCode: 400, description: "Campos obrigatórios", Type = typeof(ValidaCampoViewModelOutput))]
       [SwaggerResponse(statusCode: 500, description: "Erro interno", Type =typeof(ErroGenericoViewModel))]

       [HttpPost]
       [Route("logar")]
       [ValidacaoModelStateCustomizado]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
           // if ( !ModelState.IsValid)
           // {
          //      return BadRequest(new ValidaCampoViewModelOutput(ModelState.SelectMany(sm => sm.Value.Errors).Select(s => s.ErrorMessage)));
          //  }
            
            return Ok(loginViewModelInput);
        }

        [HttpPost]
        [Route ("Registrar")]
        [ValidacaoModelStateCustomizado]
        public IActionResult Registrar(RegistroViewModelInput loginViewModelInput)
        {

            return Created("", loginViewModelInput);
        }
    }
}
