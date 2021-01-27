using Microsoft.AspNetCore.Mvc;
using System;

namespace TodoApi21.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return DateTime.Now.ToString();
        }
    }
}