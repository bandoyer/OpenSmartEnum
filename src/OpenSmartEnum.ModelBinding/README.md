# OpenSmartEnum.ModelBinding

ASP.NET Core MVC model binding support for [OpenSmartEnum](https://www.nuget.org/packages/OpenSmartEnum). Binds SmartEnum action parameters and model properties from route values, query strings, and form fields.

## Installation

```bash
dotnet add package OpenSmartEnum.ModelBinding
```

## Usage

Register the binder provider when adding controllers:

```csharp
using OpenSmartEnum.ModelBinding;

builder.Services.AddControllers(options =>
{
    options.ModelBinderProviders.Insert(0, new SmartEnumBinderProvider());
});
```

Incoming values are matched against the enum's `Name`, ignoring case:

```csharp
[ApiController]
[Route("reservations")]
public class ReservationsController : ControllerBase
{
    // GET /reservations?status=paid binds ReservationStatus.Paid
    [HttpGet]
    public IActionResult GetByStatus([FromQuery] ReservationStatus status) => Ok(status.Name);
}
```

The binder doesn't apply to JSON request bodies. Use [OpenSmartEnum.SystemTextJson](https://www.nuget.org/packages/OpenSmartEnum.SystemTextJson) or [OpenSmartEnum.JsonNet](https://www.nuget.org/packages/OpenSmartEnum.JsonNet) for those.

## More information

See the [SmartEnum project README](https://github.com/bandoyer/OpenSmartEnum#model-binding-support) for full documentation.
