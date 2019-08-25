# MergeMatched AndCondition Expression

The `MergeMatchedAndConditionExpression` allows you to perform only the `UPDATE` in the `BulkMerge` if the specified property value is equal to the database value. 

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

    context.BulkMerge(customers, options => 
    {
        options.MergeMatchedAndConditionExpression = c => new {c.CustomerID, c.CreatedDate };
    });
}
```

[Try it in EF6](https://dotnetfiddle.net/U8vgGS) [Try it in EF Core](https://dotnetfiddle.net/uci5RT)

 - It will update all records except for the last one because the `CreatedDate` property is updated.
