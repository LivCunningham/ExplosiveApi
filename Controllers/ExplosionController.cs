using System;
using Microsoft.AspNetCore.Mvc;

namespace ExplosiveApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ExplosionController : ControllerBase
  {
    [HttpGet("{input}")]
    public ActionResult<string> GetExplosion(string input)
    {
      var res = "";
      foreach (var c in input)
      {
        res += new String(c, int.Parse(c.ToString()));
      }
      return res;
    }
  }
}