using FluetValidationTraining.Models;
using FluetValidationTraining.Validators;
using Microsoft.AspNetCore.Mvc;

namespace FluetValidationTraining.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register([FromBody] CreateUserModel model)
        {
            var validator = new RegisterValidator();
            var result = validator.Validate(model);
            if (!result.IsValid)
            {
             return BadRequest("Yashaa");
            }
            return Ok("Status kuz");
        }
    }
}
