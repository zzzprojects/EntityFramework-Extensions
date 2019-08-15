# PreBulkInsert

The `PreBulkInsert` event is raised as soon as the `BulkInsert` method is called and no configuration or anything else is done before. It allows you to set some global configuration for BulkInsert. 

The following example sets the `CreatedDate` property of a `Customer`.

```csharp
EntityFrameworkManager.PreBulkInsert = (ctx, obj) => 
{
    if(obj is IEnumerable<Customer>) 
    {
        foreach(var customer in (IEnumerable<Customer>)obj)
        {
            customer.CreatedDate = DateTime.Now;
        }
    }
};
```

[Try it in EF6](https://dotnetfiddle.net/9JUluL) | [Try it in EF Core](https://dotnetfiddle.net/sdkwxW)

In the `PreBulkInsert` event, the `CreatedDate` property is set to `DateTime.Now` before the data is inserted to the database.
