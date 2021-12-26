using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistrationWebApi.Model;
using RegistrationWebApi.Data;
//using static RegistrationWebApi.Model.Responce;

namespace RegistrationWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly RegistrationContext _context;

        public RegisterController(RegistrationContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<APIResponse>> PostRegistration(Registradata redata)
        {
            APIResponse response = new APIResponse();
            try
            {
                response.data = new RegistrationDataRepo(_context).Upsertregistration(redata);
               
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.Status = new ErrorAPIResponse(ex.Message); ;
                return Ok(response);
            }
        }
    }
}
