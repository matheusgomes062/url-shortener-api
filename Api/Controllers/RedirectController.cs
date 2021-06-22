using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace url_shortener_api.Api.Controllers
{
  [ApiController]
  public class RedirectController : ControllerBase
  {
    private readonly IMediator mediator;

    public RedirectController(IMediator mediator)
    {
      this.mediator = mediator;
    }

    [HttpGet("/{key}")]
    public async Task<IActionResult> RedirectUrl(string key)
    {
      var result = await mediator.Send(new GetUrlByKeyQuery { Key = key });
      if (result.IsSuccess) return Redirect(result.Data);
      else return result.ToResponse();
    }
  }
}