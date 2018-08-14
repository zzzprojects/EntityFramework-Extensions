# Logging

## Log
Gets or sets an action to `log` all database events as soon as they happen.


```csharp
StringBuilder logger = new StringBuilder();

context.BulkSaveChanges(options =>
{
	options.Log += s => logger.AppendLine(s);
});
```

## UseLogDump
Gets or sets if all `log` related to database event should be stored in a `LogDump` properties.


```csharp
StringBuilder logDump;

context.BulkSaveChanges(options =>
{
	options.UseLogDump = true;
	options.BulkOperationExecuted = bulkOperation => logDump = bulkOperation.LogDump;
});
```

## LogDump
Gets all `logged` database event when `UseLogDump` is enabled.


```csharp
StringBuilder logDump;

context.BulkSaveChanges(options =>
{
	options.UseLogDump = true;
	options.BulkOperationExecuted = bulkOperation => logDump = bulkOperation.LogDump;
});
```
