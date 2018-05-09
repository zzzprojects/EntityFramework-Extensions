---
permalink: batch-size
---

## Definition
Gets or sets the number of records to use in a batch.


```csharp
// Instance
context.BulkSaveChanges(options => options.BatchSize = 1000);

// Global
EntityFrameworkManager.BulkOperationBuilder = builder => builder.BatchSize = 1000;
```

## Purpose
Having access to modify the `BatchSize` default value may be useful in some occasions where the performance is very affected.

Don't try to optimize it if your application is not affected by performance problem.

## FAQ

### What's the optimized BatchSize?
Not too low, not too high!

Unfortunately, there is no magic value.

If you set it too low, the library will perform too many round-trips and it may decreases the overall performance.

If you set it too high, the library will make fewer round-trips but it could take more time to write on the server which may decrease the overall performance.

There is no perfect number since there is too many factors such as:
- Column Size
- Index
- Latency
- Trigger
- Etc.