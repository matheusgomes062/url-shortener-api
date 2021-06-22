using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace url_shortener_api.Application.Interfaces
{
  public class IValidator<TRequest>
  {
    Task<ValidationResult> Validate(TRequest request);
  }
}