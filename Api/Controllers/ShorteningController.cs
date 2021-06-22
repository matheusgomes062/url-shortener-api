using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace url_shortener_api.Api.Controllers
{
  [ApiController]
  public class ShorteningController : ControllerBase
  {
    private readonly IMediator mediator;

    public ShorteningController(IMediator mediator)
    {
      this.mediator = mediator;
    }

    [HttpPost("/shorten")]
    public async Task<IActionResult> ShortenUrl(ShortenUrlCommand command)
    {
      var result = await mediator.Send(command);
      return result.ToResponse();
    }
  }
}