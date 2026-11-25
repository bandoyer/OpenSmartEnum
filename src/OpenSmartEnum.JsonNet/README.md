# OpenSmartEnum.JsonNet

[Json.NET](https://www.newtonsoft.com/json) (Newtonsoft.Json) (de)serialization support for [OpenSmartEnum](https://www.nuget.org/packages/OpenSmartEnum). A SmartEnum should be serialized as either its `Name` or its `Value`, and this package provides converters for both.

## Installation

```bash
dotnet add package OpenSmartEnum.JsonNet
```

## Usage

Apply one of the converters with `[JsonConverter]`. To serialize by `Name`:

```csharp
using Newtonsoft.Json;
using OpenSmartEnum.JsonNet;

public class TestClass
{
    [JsonConverter(typeof(SmartEnumNameConverter<TestEnum, int>))]
    public TestEnum Property { get; set; }
}
```

```json
{ "Property": "One" }
```

To serialize by `Value`:

```csharp
public class TestClass
{
    [JsonConverter(typeof(SmartEnumValueConverter<TestEnum, int>))]
    public TestEnum Property { get; set; }
}
```

```json
{ "Property": 1 }
```

For `SmartFlagEnum` types, use `SmartFlagEnumNameConverter<TEnum, TValue>` or `SmartFlagEnumValueConverter<TEnum, TValue>`.

## More information

See the [SmartEnum project README](https://github.com/bandoyer/OpenSmartEnum) for full documentation.
