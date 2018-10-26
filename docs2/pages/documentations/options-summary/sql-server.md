# SQL Server

## SqlBulkCopyOptions
Gets or sets the SqlBulkCopyOptions to use when `SqlBulkCopy` is used to directly insert in the destination table.


```csharp
context.BulkSaveChanges(options =>
{
   options.SqlBulkCopyOptions = SqlBulkCopyOptions.Default | SqlBulkCopyOptions.TableLock;
});
```
{% include component-try-it.html href='https://dotnetfiddle.net/j4jhLe' %}
