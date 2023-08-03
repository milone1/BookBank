using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nueva_app.Models;
using Nueva_app.Services;

namespace Nueva_app.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public BeerService _beerService;

        public UserController(BeerService beerService)
        {
            _beerService = beerService;
        }

        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return _beerService.Get();
        }

        [HttpPost]
        public ActionResult<User> Create(User user)
        {

            _beerService.Create(user);
            return Ok(user);
        }

        [HttpPut]
        public ActionResult Update(User user)
        {
            _beerService.Update(user.Id, user);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            _beerService.Delete(id);
            var response = new
            {
                msg = "Eliminado correctamente!!!!",
                another = true
            };

            return Ok(response);
        }
    }
}
