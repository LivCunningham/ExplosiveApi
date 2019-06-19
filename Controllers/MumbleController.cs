using System;
using Microsoft.AspNetCore.Mvc;

namespace MumbleApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class MumbleController : ControllerBase
  {
    [HttpGet("{input}")]
    public ActionResult<string> GetMumble(string input)
    {
      {
        string result = "";
        char[] stringArray;
        stringArray = input.ToCharArray();
        for (int i = 0; i < stringArray.Length; i++)
        {
          char.ToLower(stringArray[i]);
          for (int j = 0; j <= i; j++)
          {
            if (j == 0)
            {
              result = result + char.ToUpper(stringArray[i]);
            }
            else
            {
              result = result + char.ToLower(stringArray[i]);
            }
          }
          if (i != stringArray.Length - 1)
          {
            result = result + '-';
          }

        }
        return result;
      }
    }
  }
}