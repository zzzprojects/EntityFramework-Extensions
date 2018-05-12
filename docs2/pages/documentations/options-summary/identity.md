# Identity

### InsertKeepIdentity
Gets or sets if the source identity value should be preserved on `Insert`. When not specified, identity values are assigned by the destination.


```csharp
context.BulkInsert(list, options => options.InsertKeepIdentity = true);
```

---

### MergeKeepIdentity
Gets or sets if the source identity value should be preserved on `Merge`. When not specified, identity values are assigned by the destination.


```csharp
context.BulkMerge(list, options => options.MergeKeepIdentity = true);
```

---

### SynchronizeKeepIdentity
Gets or sets if the source identity value should be preserved on `Synchronize`. When not specified, identity values are assigned by the destination.


```csharp
context.BulkSynchronize(list, options => options.SynchronizeKeepIdentity = true);
```