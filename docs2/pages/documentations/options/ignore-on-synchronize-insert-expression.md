# IgnoreOnSynchronizeInsertExpression

The `IgnoreOnSynchronizeInsertExpression` allows you to ignore some columns when the `BulkSynchronize` method executes the `insert` statement and these columns will only be used in `update` statement.

The following example ignores the `Description` property in insertion and will be considered when updating the records.

```csharp
using (var context = new EntityContext())
{
    var customers = context.Customers.Take(2).ToList();
    customers.ForEach(x => { x.Name += "_Updated"; x.Description += "_Updated"; x.IsActive = false; });
    customers.Add(new Customer() { Name = "Alexander", Description = "Description of Alexander", IsActive = true });

    context.BulkSynchronize(customers, options => 
    {
        options.IgnoreOnSynchronizeInsertExpression = customer => new {customer.CustomerID,  customer.Description};
    });
}
```

{% include component-try-it.html href='https://dotnetfiddle.net/bCXqPB' %}

 - It updates all the columns of existing records.
 - I will insert data of new records in all the columns except for the `Description` column because `Description` property is specified in `IgnoreOnSynchronizeInsertExpression`. 
 - It will also delete all those records which are in the source (`customers` list)
