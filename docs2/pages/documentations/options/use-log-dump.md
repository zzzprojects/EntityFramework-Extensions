# UseLogDump

## Definition
The `BulkOperation.UseLogDump` property sets if all log related to database events should be stored in a `LogDump` property or not. 

The following example sets `UseLogDump` to `true` and assigns `LogDump` to local `StringBuilder` variable `logDump` when the `BulkOperationExecuted` event is executed. 

```csharp
StringBuilder logDump;

context.BulkSaveChanges(options =>
{
    options.UseLogDump = true;
    options.BulkOperationExecuted = bulkOperation =>
    {
        logDump = bulkOperation.LogDump;
    };
});
```

[Try it in EF6](https://dotnetfiddle.net/Z2klLQ) | [Try it in EF Core](https://dotnetfiddle.net/jIz1br)

## Purpose
Getting database `log` can often be useful for debugging and see what has been executed under the hood by the library.
