# Coalesce Destination OnUpdate Expression

The `CoalesceDestinationOnUpdateExpression` is the inverse of `CoalesceOnUpdateExpression`, it allows you to update the new value if the database value is null otherwise keep the database value when `BulkUpdate` method is executed.

The following example will update only those columns for which the value is null in the database for the specified properties.

```csharp
using (var context = new EntityContext())
{
    var list = context.Customers.ToList();
    list.ForEach(x => { x.Name += "_Updated"; x.Description += "Add Description"; x.IsActive = false; });
			
    context.BulkUpdate(list, options => 
    {
        options.CoalesceDestinationOnUpdateExpression = c => new {c.CustomerID, c.Name, c.Description};
    });				  BulkUpdate
}
```

[Try it in EF6](https://dotnetfiddle.net/oJgbnd) | [Try it in EF Core](https://dotnetfiddle.net/DVfHF4)

 - It will update the value in the `Description` column because the database value is null.
 - The value for `Name` is not null so it will not update the `Name` column.
 - The `IsActive` will also be updated, because it is not specified in `CoalesceDestinationOnUpdateExpression`.
