# Changelog

The notes for versions up to 9.0.0 are in [ardalis/SmartEnum's GitHub Releases](https://github.com/ardalis/SmartEnum/releases).

## 10.0.0 (2026-11-25)

### Breaking changes

- The library is now `OpenSmartEnum`, continuing `Ardalis.SmartEnum` 9.0.0 under the MIT license. All 11 packages (`OpenSmartEnum`, `OpenSmartEnum.AutoFixture`, `OpenSmartEnum.Dapper`, `OpenSmartEnum.EFCore`, `OpenSmartEnum.GuardClauses`, `OpenSmartEnum.JsonNet`, `OpenSmartEnum.MessagePack`, `OpenSmartEnum.ModelBinding`, `OpenSmartEnum.ProtoBufNet`, `OpenSmartEnum.SystemTextJson`, and `OpenSmartEnum.Utf8Json`) share the `OpenSmartEnum` prefix for their package IDs, assembly names, and root namespaces.
  - To migrate from `Ardalis.SmartEnum` 8.x or 9.0.0:
    1. Replace each `Ardalis.SmartEnum*` package reference with the matching `OpenSmartEnum*` package at `10.0.0`.
    2. Replace `Ardalis.SmartEnum` with `OpenSmartEnum` in your `using` directives and fully qualified type names (and `SmartEnum.EFCore` with `OpenSmartEnum.EFCore` if upgrading from 8.x).
    3. If you use `OpenSmartEnum.GuardClauses`, it now depends on [`OpenGuardClauses`](https://www.nuget.org/packages/OpenGuardClauses) (`7.0.0`) instead of `Ardalis.GuardClauses`; replace `using Ardalis.GuardClauses;` with `using OpenGuardClauses;`.
  - Because the package IDs, assemblies, and root namespaces differ, an application can reference `Ardalis.SmartEnum` and `OpenSmartEnum` side by side during migration.
- Targets `net10.0`, `net11.0`, and `netstandard2.0` (`OpenSmartEnum.EFCore` targets `net10.0` and `net11.0`), carried over from `Ardalis.SmartEnum` 9.0.0.
- The packages ship without an icon in 10.0.0.

### Included from Ardalis.SmartEnum 9.0.0

- `OpenSmartEnum.EFCore`'s `ConfigureSmartEnum()` lives in the `OpenSmartEnum.EFCore` namespace, matching the other packages.
- Each companion package ships its own NuGet README with usage examples.
- Dependencies updated to their latest versions.
- Null checks consistently use pattern matching.
- Corrected documented exception type for `FromValue`.
- Packages declare the `MIT` SPDX license expression and include `LICENSE`.
