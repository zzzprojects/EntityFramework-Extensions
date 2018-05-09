# Log

## Definition
Gets or sets an action to `log` all database events as soon as they happen.


```csharp
StringBuilder logger = new StringBuilder();

context.BulkSaveChanges(options =>
{
	options.Log += s => logger.AppendLine(s);
});
```

## Purpose
Getting database `log` can often be useful for debugging and see what has been executed under the hood by the library.