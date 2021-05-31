using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.MODELS;
using WebApplication1.MODELS.Entities;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("APIPRUEBA/[controller]/")]
    public class UsersController : ControllerBase
    {
        private IusersCrud iusersCrud;
        public UsersController(IusersCrud iUsersCrud)
        {
            iusersCrud = iUsersCrud;
        }
        [HttpPost("autenticacionUser")]
        
        public IActionResult autenticacion(UsersEntity credentials)
        {
           var result= iusersCrud.GetUsers(credentials.IDENTIFICACION, credentials.PASS);
            if (result != null)
            {
                return StatusCode(200,"ok");
                    }
            else
            {
                return StatusCode(404, "usuario o  contraseña incorrecto");
            }

            
        }

    }
}
