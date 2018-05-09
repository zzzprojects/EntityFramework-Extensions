---
permalink: ignore-on-merge-update-expression
---

## Definition
Gets or sets columns to ignore when the `BulkMerge` method executes the `update` statement.


```csharp
context.BulkMerge(list, options => 
        options.IgnoreOnMergeUpdateExpression = entity => new {entity.CreatedDate, entity.CreatedDate}
); 
```

## Purpose
The `IgnoreOnMergeUpdateExpression` option lets you ignore some columns that should be only `insert.

By example, when you need to `insert` the CreatedDate and CreatedDate but not `update` the value.
