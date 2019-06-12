# Ignore OnSynchronizeMatched AndCondition Expression

The `IgnoreOnSynchronizeMatchedAndConditionExpression` is the inverse of `SynchronizeMatchedAndConditionExpression`.

 - The `SynchronizeMatchedAndConditionExpression` allows you to perform the bulk synchronize operation if the specified property value is not equal to the database value.
 - So by default, all columns are included in `IgnoreOnSynchronizeMatchedAndConditionExpression` but not the one you choose to ignore.

The following example updates all those records in which the `CreatedDate` property is equal to database value and ignore the specified properties in `IgnoreOnUpdateMatchedAndConditionExpression` if their value is equal to the database or not.

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
        options.IgnoreOnSynchronizeMatchedAndConditionExpression = c => new 
        {
            c.Name, 
            c.Description, 
            c.ModifiedDate, 
            c.IsActive 
        };
    });
}
```

{% include component-try-it.html href='https://dotnetfiddle.net/eta7wV' %}

 - It will update all the records except for the last record because the `CreatedDate` property is updated for the last record.
