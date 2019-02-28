# Phema.DateTime
C# DateTime DI services

```csharp
// Utc
services.AddPhemaUtcDateTime();

// Local
services.AddPhemaLocalDateTime();

// Resolve
var dateTime = provider.GetRequiredService<IDateTime>();

// Use
var now = dateTime.Now;
```
