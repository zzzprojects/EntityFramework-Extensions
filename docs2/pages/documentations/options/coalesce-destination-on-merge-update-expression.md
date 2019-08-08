# Coalesce Destination OnMergeUpdate Expression

The `CoalesceDestinationOnMergeUpdateExpression` is the inverse of `CoalesceOnMergeUpdateExpression`, it allows you to update the new value if the database value is null otherwise it keeps the database value when `BulkMerge` method is executed.

The following example will update only those columns for which the value is null in the database for the specified properties.

```csharp
using (var context = new EntityContext())
{
    var list = context.Customers.ToList();
    list.ForEach(x => { x.Name += "_Updated"; x.Description += "Add Description"; x.IsActive = false; });
    list.Add(new Customer() { Name ="Customer_C", Description = "Description of C", IsActive = false});
    
    context.BulkMerge(list, options => 
    {
        options.CoalesceDestinationOnMergeUpdateExpression = c => new {c.CustomerID, c.Name, c.Description};
    });                  
}
```

[Try it in EF6](https://dotnetfiddle.net/VQscMY) | [Try it in EF Core](https://dotnetfiddle.net/zcIYs0)

 - It will update the value in the `Description` column because the database value is null.
 - The value for `Name` is not null so it will not update the `Name` column.
 - The `IsActive` will also be updated, because it is not specified in `CoalesceDestinationOnMergeUpdateExpression`.
