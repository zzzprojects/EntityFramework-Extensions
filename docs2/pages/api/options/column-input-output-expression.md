---
permalink: column-input-output-expression
---

## Definition
Gets or sets columns to map with the direction `InputOutput`.

The key is required for operations such as `BulkUpdate` and `BulkMerge`.


```csharp
context.BulkMerge(list, options => 
        options.ColumnInputOutputExpression = entity => new {entity.ID, entity.Code}
); 
```

## Purpose
The `ColumnInputOutputExpression` option lets you choose specific properties in which you want to perform the bulk operations.

By example, when importing a file, you may have not data on all properties.