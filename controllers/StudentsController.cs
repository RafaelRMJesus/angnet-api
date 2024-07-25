using Microsoft.AspNetCore.Mvc;

namespace angnet_api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class StudentsController : ControllerBase
  {
    [HttpGet]
    public string SayHi()
    {
      return "Hi";
    }
  }
}