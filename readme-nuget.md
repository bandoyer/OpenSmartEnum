# OpenSmartEnum

Classes to help produce strongly typed smarter enums in .NET, continuing Ardalis.SmartEnum under the MIT license.

[CHANGELOG.md](https://github.com/bandoyer/OpenSmartEnum/blob/main/CHANGELOG.md) lists each version's changes and breaking changes, and how to move a project from Ardalis.SmartEnum 8.x or 9.0.0 to 10.0.0.

## Usage

Define a smart enum by inheriting from `SmartEnum<TEnum>`:

```csharp
using OpenSmartEnum;

public sealed class TestEnum : SmartEnum<TestEnum>
{
    public static readonly TestEnum One = new TestEnum(nameof(One), 1);
    public static readonly TestEnum Two = new TestEnum(nameof(Two), 2);
    public static readonly TestEnum Three = new TestEnum(nameof(Three), 3);

    private TestEnum(string name, int value) : base(name, value)
    {
    }
}
```

Then look up and list values:

```csharp
var two = TestEnum.FromName("Two");      // or TestEnum.FromValue(2)

if (TestEnum.TryFromValue(3, out var three))
{
    Console.WriteLine(three.Name);       // "Three"
}

foreach (var option in TestEnum.List)
{
    Console.WriteLine($"{option.Name} = {option.Value}");
}
```

Smart enums can also carry behavior:

```csharp
public abstract class EmployeeType : SmartEnum<EmployeeType>
{
    public static readonly EmployeeType Manager = new ManagerType();
    public static readonly EmployeeType Assistant = new AssistantType();

    private EmployeeType(string name, int value) : base(name, value) { }

    public abstract decimal BonusSize { get; }

    private sealed class ManagerType : EmployeeType
    {
        public ManagerType() : base("Manager", 1) { }
        public override decimal BonusSize => 10_000m;
    }

    private sealed class AssistantType : EmployeeType
    {
        public AssistantType() : base("Assistant", 2) { }
        public override decimal BonusSize => 1_000m;
    }
}
```

Companion packages add support for EF Core, Dapper, System.Text.Json, Json.NET, MessagePack, protobuf-net, Utf8Json, AutoFixture, ASP.NET Core model binding, and OpenGuardClauses. See the [full project README](https://github.com/bandoyer/OpenSmartEnum) for details.
