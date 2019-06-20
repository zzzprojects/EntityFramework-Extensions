# SqlBulkCopyOptions

## Definition
Gets or sets the SqlBulkCopyOptions to use when `SqlBulkCopy` is used to directly insert in the destination table.


```csharp
context.BulkSaveChanges(options =>
{
   options.SqlBulkCopyOptions = SqlBulkCopyOptions.Default | SqlBulkCopyOptions.TableLock;
});
```

## Purpose
Modifying the SqlBulkCopyOptions to include for example `TableLock` may increase significantly the performance.