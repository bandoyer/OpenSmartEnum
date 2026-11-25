# OpenSmartEnum.Utf8Json

[Utf8Json](https://github.com/neuecc/Utf8Json) (de)serialization support for [OpenSmartEnum](https://www.nuget.org/packages/OpenSmartEnum). A SmartEnum should be serialized as either its `Name` or its `Value`, and this package provides formatters and resolvers for both.

## Installation

```bash
dotnet add package OpenSmartEnum.Utf8Json
```

## Usage

Apply a formatter to a property with `[JsonFormatter]`:

```csharp
using OpenSmartEnum.Utf8Json;
using Utf8Json;

public class TestClass
{
    [JsonFormatter(typeof(SmartEnumNameFormatter<TestEnum, int>))]
    public TestEnum ByName { get; set; }

    [JsonFormatter(typeof(SmartEnumValueFormatter<TestEnum, int>))]
    public TestEnum ByValue { get; set; }
}
```

Or handle every SmartEnum type at once by registering a resolver:

```csharp
using Utf8Json.Resolvers;

CompositeResolver.RegisterAndSetAsDefault(
    SmartEnumNameResolver.Instance,
    StandardResolver.Default);
```

`SmartEnumValueResolver`, `SmartFlagEnumNameResolver`, and `SmartFlagEnumValueResolver`, plus matching `SmartFlagEnum*Formatter` types, are also available.

## More information

See the [SmartEnum project README](https://github.com/bandoyer/OpenSmartEnum) for full documentation.
