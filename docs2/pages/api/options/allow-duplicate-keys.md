# AllowDuplicateKeys

## Definition
Gets or sets if a duplicate key is possible in the source.


```csharp
context.BulkMerge(list, options => options.AllowDuplicateKeys = true);
```

## Purpose
In a rare scenario such as importing a file, a key may be used in multiple rows.

In some provider such as SQL Server, the statement created by our library (`Merge`) makes it impossible to use with some duplicate keys.

By enabling this option, only the latest key is used instead.

