# Phema.DateTime

[![Nuget](https://img.shields.io/nuget/v/Phema.DateTime.svg)](https://www.nuget.org/packages/Phema.DateTime)

C# DateTime wrapper for `Microsoft.Extensions.DependencyInjection`

## Packages

- `Phema.DateTime` - Core abstractions
- `Phema.DateTime.Utc` - `.AddUtcDateTime()`
- `Phema.DateTime.Local` - `.AddLocalDateTime()`

## Usage

```csharp
// Add
services.AddUtcDateTime(); // .AddLocalDateTime();

// Get
var dateTime = provider.GetRequiredService<IDateTime>();

// Use
var now = dateTime.Now;
```
