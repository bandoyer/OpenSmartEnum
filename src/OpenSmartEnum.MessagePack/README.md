# OpenSmartEnum.MessagePack

[MessagePack](https://github.com/MessagePack-CSharp/MessagePack-CSharp) (de)serialization support for [OpenSmartEnum](https://www.nuget.org/packages/OpenSmartEnum). A SmartEnum should be serialized as either its `Name` or its `Value`, and this package provides formatters and resolvers for both.

## Installation

```bash
dotnet add package OpenSmartEnum.MessagePack
```

## Usage

Apply a formatter to a property with `[MessagePackFormatter]`:

```csharp
using OpenSmartEnum.MessagePack;
using MessagePack;

[MessagePackObject]
public class TestClass
{
    [Key(0)]
    [MessagePackFormatter(typeof(SmartEnumNameFormatter<TestEnum, int>))]
    public TestEnum ByName { get; set; }

    [Key(1)]
    [MessagePackFormatter(typeof(SmartEnumValueFormatter<TestEnum, int>))]
    public TestEnum ByValue { get; set; }
}
```

Or handle every SmartEnum type at once by adding a resolver to your serializer options:

```csharp
using MessagePack.Resolvers;

var options = MessagePackSerializerOptions.Standard.WithResolver(
    CompositeResolver.Create(SmartEnumNameResolver.Instance, StandardResolver.Instance));
```

`SmartEnumValueResolver`, `SmartFlagEnumNameResolver`, and `SmartFlagEnumValueResolver`, plus matching `SmartFlagEnum*Formatter` types, are also available.

## More information

See the [SmartEnum project README](https://github.com/bandoyer/OpenSmartEnum) for full documentation.
