# CoalesceOnMergeUpdateExpression

The `CoalesceOnMergeUpdateExpression` allows you to not update any column if the specified value is `null` and it is not null in the database.

The following example will update only those columns in which the specified value is not null.

```csharp
using (var context = new EntityContext())
{
    var list = context.Customers.ToList();
    list.ForEach(x => { x.Name += "_Updated"; x.Description = null; x.IsActive = false;});
    list.Add(new Customer() { Name ="Customer_C", Description = null, IsActive = false});
    
    context.BulkMerge(list, options => 
    {
        options.CoalesceOnMergeUpdateExpression = c => new {c.CustomerID, c.Description};
    });                  
}
```

{% include component-try-it.html href='https://dotnetfiddle.net/JOrTfP' %}

 - It will update only `Name` and `Active` columns because the new specified values are null.
 - The new value for `Description` is so it will not update the `Description` column.
