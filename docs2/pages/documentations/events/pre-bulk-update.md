# PreBulkUpdate

The `PreBulkUpdate` event is raised as soon the `BulkUpdate` method is called and no configuration or anything else is done before. It allows you to set some global configuration for BulkUpdate. 

The following example sets the `ModifiedDate` property of a `Customer`.

```csharp
EntityFrameworkManager.PreBulkUpdate = (ctx, obj) => 
{
    if(obj is IEnumerable<Customer>) 
    {
        foreach(var customer in (IEnumerable<Customer>)obj)
        {
            customer.ModifiedDate = DateTime.Now;
        }
    }
};
```

{% include component-try-it.html href='https://dotnetfiddle.net/9JUluL' %}

In the `PreBulkUpdate` event, the `ModifiedDate` property is set to `DateTime.Now` before the data is updated to the database.
