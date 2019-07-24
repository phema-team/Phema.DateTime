# Phema.DateTime

C# DateTime wrapper for `Microsoft.Extensions.DependencyInjection` with built-on testing support

## Packages

- [![Nuget](https://img.shields.io/nuget/v/Phema.DateTime.svg)](https://www.nuget.org/packages/Phema.DateTime) `Phema.DateTime` - Core abstractions
- [![Nuget](https://img.shields.io/nuget/v/Phema.DateTime.Utc.svg)](https://www.nuget.org/packages/Phema.DateTime.Utc) `Phema.DateTime.Utc` - `.AddUtcDateTime()`
- [![Nuget](https://img.shields.io/nuget/v/Phema.DateTime.Local.svg)](https://www.nuget.org/packages/Phema.DateTime.Local)  `Phema.DateTime.Local` - `.AddLocalDateTime()`
- [![Nuget](https://img.shields.io/nuget/v/Phema.DateTime.Test.svg)](https://www.nuget.org/packages/Phema.DateTime.Test)  `Phema.DateTime.Test` - `.AddTestDateTime(...)`

## Usage

```csharp
// Add
services.AddUtcDateTime(); // .AddLocalDateTime(); or .AddTestDateTime(...)

// Get
var dateTime = provider.GetRequiredService<IDateTime>();

// Use
var now = dateTime.Now;
```
