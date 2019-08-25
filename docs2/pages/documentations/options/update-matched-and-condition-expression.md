# UpdateMatched AndCondition Expression

The `UpdateMatchedAndConditionExpression` allows you to perform the bulk update operation if the specified property value is equal to the database value. 

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
    context.BulkUpdate(customers, options => 
    {
        options.UpdateMatchedAndConditionExpression = c => new {c.CustomerID, c.CreatedDate };
    });
}
```

[Try it in EF6](https://dotnetfiddle.net/qq3XCY) | [Try it in EF Core](https://dotnetfiddle.net/NUwq90)

 - It will update all the records except for the last one because the `CreatedDate` property is updated.
