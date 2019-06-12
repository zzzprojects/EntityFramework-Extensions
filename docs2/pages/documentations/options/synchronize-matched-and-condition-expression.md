# SynchronizeMatched AndCondition Expression

The `SynchronizeMatchedAndConditionExpression` allows you to perform the bulk synchronize operation if the specified property value is equal to the database value. 

The following example updates all those records in which `CreatedDate` value is equal to the database value.

```csharp
using (var context = new EntityContext())
{
    var customers = context.Customers.ToList();
    customers.ForEach(x => 
    {
        x.Name += "_Updated"; 
        x.Description += "_Updated"; 
        x.ModifiedDate = DateTime.Now; 
        x.IsActive = false; 
    });
    
    customers.Last().CreatedDate = DateTime.Now;

    context.BulkSynchronize(customers, options => 
    {
        options.SynchronizeMatchedAndConditionExpression = c => new {c.CustomerID, c.CreatedDate };
    });
}
```

{% include component-try-it.html href='https://dotnetfiddle.net/5W8jyb' %}

 - It will update all the records except for the last record because the `CreatedDate` property is updated for the last record.
