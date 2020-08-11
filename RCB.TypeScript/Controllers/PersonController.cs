using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RCB.TypeScript.Models;
using RCB.TypeScript.Services;

namespace RCB.TypeScript.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private UserService UserService { get; }

        public PersonController(UserService userService)
        {
            UserService = userService;
        }

        [HttpGet("[action]")]
        public IActionResult Search([FromQuery]string term = null)
        {
            return Json(UserService.Search(term));
        }

        [HttpPost("[action]")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Add(User model)
        {
            if (model == null)
                return BadRequest($"{nameof(model)} is null.");
            var result = UserService.Add(model);
            return Json(result);
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Update(User model)
        {
            if (model == null)
                return BadRequest($"{nameof(model)} is null.");
            var result = UserService.Update(model);
            
            return Json(result);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest($"{nameof(id)} <= 0.");
            var result = UserService.Delete(id);
            return Json(result);
        }
    }
}