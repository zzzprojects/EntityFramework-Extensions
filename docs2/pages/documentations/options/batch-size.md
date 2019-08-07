# Batch-size

## Definition

Batch size is the number of records in each batch. The rows in a batch are sent to the server at the end of each batch.

The `BatchSize` property gets or sets the number of records to use in a batch. The following example save bulk data in batches of 1000 rows. 

```csharp
context.BulkSaveChanges(options => options.BatchSize = 1000);
```
[Try it in EF6](https://dotnetfiddle.net/BThvHs) | [Try it in EF Core](https://dotnetfiddle.net/qonEbL)

 - A batch is complete when `BatchSize` rows have been processed or there are no more rows to send to the destination data source.
 - The default value is zero which indicates that each operation is a single batch.

You can also set batch size globally using `EntityFrameworkManager.BulkOperationBuilder`.

```csharp
// Global
EntityFrameworkManager.BulkOperationBuilder = builder => builder.BatchSize = 1000;
```

## Purpose
Having access to modify the `BatchSize` default value may be useful in some occasions where the performance is very affected.

Don't try to optimize it if your application is not affected by the performance problem.

## FAQ

### What's the optimized BatchSize?
Not too low, not too high!

Unfortunately, there is no magic value.

 - If you set it too low, the library will perform too many round-trips and it may decrease the overall performance.
 - If you set it too high, the library will make fewer round-trips, but it could decrease the overall performance by taking more time to write on the server.

There is no perfect number since there are too many factors such as:
- Column Size
- Index
- Latency
- Trigger
- Etc.
