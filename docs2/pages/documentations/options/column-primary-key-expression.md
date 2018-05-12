# ColumnPrimaryKeyExpression

## Definition
Gets or sets columns to use as the `key` for the operation.


```csharp
context.BulkMerge(list, options => 
        options.ColumnPrimaryKeyExpression = entity => new { entity.Code1, entity.Code2 }
); 
```

## Purpose
The `ColumnPrimaryKeyExpression` option lets you choose a specific key to use to perform the bulk operations.

By example, when importing a file, you may not have access to the `ID` but a unique `Code` instead.