# MergeKeepIdentity

## Definition
Gets or sets if the source identity value should be preserved on `Merge`. When not specified, identity values are assigned by the destination.


```csharp
context.BulkMerge(options => options.MergeKeepIdentity = true);
```

## Purpose
The `MergeKeepIdentity` option lets you keep the source identity value when `merging`.

By example, when importing a file, you may want to keep the specified value.