﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AS2324_5G_INF_UbaldiEdoardo_WebAPIRec.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        [HttpGet("celsius_to_fahrenheit")]
        public JsonResult celsius_to_fahrenheit(double celsius)
        {
            return new JsonResult(
                new
                {
                    status = "OK",
                    risultato = (celsius * 9 / 5) + 32,
                    message = "Risultato",
                });
        }

        [HttpGet("volume_cylinder")]
        public JsonResult volume_cylinder(double radius, double height)
        {
            return new JsonResult(
                new
                {
                    status = "OK",
                    risultato = Math.PI * Math.Pow(radius, 2) * height,
                    message = "Risultato",
                });
        }

    }
}
