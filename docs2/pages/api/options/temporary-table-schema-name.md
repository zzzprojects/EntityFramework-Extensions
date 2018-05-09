---
permalink: temporary-table-schema-name
---

## Definition
Gets or sets the schema name to use for the temporary table.


```csharp
context.BulkSaveChanges(options =>
{
   options.TemporaryTableSchemaName = "zzz";
});
```

## Purpose
In very rare occasions, you may need to specify a schema name. By example, when also using `UsePermanentTable` option.