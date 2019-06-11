# PreBatchSaveChanges

The `PreBatchSaveChanges` event is raised as soon the `BatchSaveChanges` method is called and no configuration or anything else is done before. It allows you to set some global configuration for `BatchSaveChanges`. 

The following example sets the `CreatedDate` for new customers and `ModifiedDate` property for existing customers.

```csharp
EntityFrameworkManager.PreBatchSaveChanges = ctx =>
{
    var modifiedEntities = ctx.ChangeTracker.Entries().ToList();

    foreach (var change in modifiedEntities)
    {
        var objectStateEntry = ((IObjectContextAdapter)ctx).ObjectContext.ObjectStateManager.GetObjectStateEntry(change.Entity);

        if (objectStateEntry.State == EntityState.Added)
        {
            change.CurrentValues["CreatedDate"] = DateTime.Now;
        }
        else if (objectStateEntry.State == EntityState.Modified)
        {
            change.CurrentValues["ModifiedDate"] = DateTime.Now;
        }
    }
};
```

{% include component-try-it.html href='https://dotnetfiddle.net/UtcHa2 ' %}

In the `PreBatchSaveChanges` event, the `CreatedDate` for new customers and `ModifiedDate` property for existing customers is set to `DateTime.Now` before the data is saved to the database.
