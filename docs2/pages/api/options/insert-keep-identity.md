---
permalink: insert-keep-identity
---

## Definition
Gets or sets if the source identity value should be preserved on `Insert`. When not specified, identity values are assigned by the destination.


```csharp
context.Insert(options => options.InsertKeepIdentity = true);
```

## Purpose
The `InsertKeepIdentity` option let you keep the source identity value when `inserting`.

By example, when importing a file, you may want to keep the value specified.