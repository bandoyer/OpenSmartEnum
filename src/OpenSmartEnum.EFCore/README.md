# OpenSmartEnum.EFCore

[Entity Framework Core](https://learn.microsoft.com/ef/core/) support for [OpenSmartEnum](https://www.nuget.org/packages/OpenSmartEnum). Configures value conversions for every SmartEnum property in your model with a single call, so each one is stored as its `Value`.

## Installation

```bash
dotnet add package OpenSmartEnum.EFCore
```

## Usage

Call `ConfigureSmartEnum()` at the start of `ConfigureConventions` in your `DbContext`:

```csharp
using OpenSmartEnum.EFCore;

protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
{
    configurationBuilder.ConfigureSmartEnum();
}
```

Alternatively, call it at the end of `OnModelCreating`:

```csharp
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    // ... your configuration

    modelBuilder.ConfigureSmartEnum();
}
```

> **Migrating from Ardalis.SmartEnum.EFCore?** Replace the package with `OpenSmartEnum.EFCore` and update your `using` directive to `using OpenSmartEnum.EFCore;`.

To configure a single property yourself, without this package, use a standard EF Core value conversion:

```csharp
builder.Entity<Policy>()
    .Property(p => p.PolicyStatus)
    .HasConversion(
        p => p.Value,
        p => PolicyStatus.FromValue(p));
```

## More information

See the [SmartEnum project README](https://github.com/bandoyer/OpenSmartEnum#persisting-with-ef-core-21-or-higher) for full documentation, including storing a SmartEnum in its own lookup table.
