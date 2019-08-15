# PreBulkDelete

The `PreBulkDelete` event is raised as soon as the `BulkDelete` method is called and no configuration or anything else is done before. It allows you to set some global configuration for `BulkDelete`. 

The following example deletes softly the list of customers by updating the `IsDeleted` to `true` and clear the list.

```csharp
EntityFrameworkManager.PreBulkDelete = (ctx, obj) => 
{
    var list = obj as IEnumerable<Customer>;

    foreach (var customer in list)
    {
        customer.IsDeleted = true;
    }

    ctx.BulkUpdate(list);

    ((List<Customer>)obj).Clear();
};
```

[Try it in EF6](https://dotnetfiddle.net/9ExoFg) | [Try it in EF Core](https://dotnetfiddle.net/S1X9u1)

 - In the `PreBulkDelete` event, the `IsDeleted` to `true` and clear the `obj` (list of customers).
 - So, that `BulkDelete` doesn't delete these datas from the database permanently.
