# BatchTimeout

## Definition

Batch timeout is the number of seconds for the operation to complete before it times out.

The `BatchTimeout` gets or sets the maximum time in seconds to wait for a batch before the command throws a timeout exception. The following example modifies the timeout to 180 seconds when bulk saving data.

```csharp
context.BulkSaveChanges(options => options.BatchTimeout = 180);
```
[Try it in EF6](https://dotnetfiddle.net/HDmeWa) | [Try it in EF Core](https://dotnetfiddle.net/Uvvffx)

You can also set batch size globally using `EntityFrameworkManager.BulkOperationBuilder`.

```csharp
// Global
EntityFrameworkManager.BulkOperationBuilder = builder => builder.BatchTimeout = 180;
```

## Purpose
Having access to change the `BatchTimeout` gives you the flexibility required when some operations are too slow to complete due to several reasons such as:
- Batch Size
- Column Size
- Latency
- Trigger
- Etc.
