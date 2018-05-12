# LogDump

## Definition
Gets all `logged` database event when `UseLogDump` is enabled.


```csharp
StringBuilder logDump;

context.BulkSaveChanges(options =>
{
	options.UseLogDump = true;
	options.BulkOperationExecuted = bulkOperation => logDump = bulkOperation.LogDump;
});
```


## Purpose
Getting database `log` can often be useful for debugging and see what has been executed under the hood by the library.