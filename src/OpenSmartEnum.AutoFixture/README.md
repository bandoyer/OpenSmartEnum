# OpenSmartEnum.AutoFixture

[AutoFixture](https://github.com/AutoFixture/AutoFixture) support for [OpenSmartEnum](https://www.nuget.org/packages/OpenSmartEnum). New SmartEnum instances should never be created; code should always use the existing static instances. This package teaches AutoFixture to pick one of those instead of constructing a new one.

## Installation

```bash
dotnet add package OpenSmartEnum.AutoFixture
```

## Usage

Add `SmartEnumCustomization` to your fixture:

```csharp
using OpenSmartEnum.AutoFixture;
using AutoFixture;

var fixture = new Fixture()
    .Customize(new SmartEnumCustomization());

var smartEnum = fixture.Create<TestEnum>(); // one of TestEnum's defined values
```

## More information

See the [SmartEnum project README](https://github.com/bandoyer/OpenSmartEnum#autofixture-support) for full documentation.
