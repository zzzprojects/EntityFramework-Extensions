# Ignore OnUpdate Expression

The `IgnoreOnUpdateExpression` allows you to ignore some columns when the `BulkUpdate` method is executed.

The following example ignores the `CreatedDate` property when bulk update operation is performed.

```csharp
using (var context = new EntityContext())
{	
    var customers = context.Customers.ToList();
    customers.ForEach(x => 
    { 
        x.Name += "_Updated"; 
        x.Description += "_Updated"; 
        x.CreatedDate = DateTime.Now; 
        x.ModifiedDate = DateTime.Now; 
        x.IsActive = false; 
    });

    context.BulkUpdate(customers, options => 
    {
        options.IgnoreOnUpdateExpression = customer => new 
        {
            customer.CustomerID,  
            customer.CreatedDate
         };
    });
}
```

[Try it in EF6](https://dotnetfiddle.net/rKFA73) | [Try it in EF Core](https://dotnetfiddle.net/JdDCHB)

 - It will update data in all the columns except for the `CreatedDate` column because `CreatedDate` property is specified in `IgnoreOnUpdateExpression`. 
