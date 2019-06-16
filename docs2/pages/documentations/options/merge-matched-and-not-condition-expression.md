# MergeMatched AndNotCondition Expression

The `MergeMatchedAndNotConditionExpression` allows you to perform only the `UPDATE` in the `BulkMerge` if the specified property value is not equal to the database value. 

The following example updates all those records in which `ModifiedDate` value is not equal to the database value.

```csharp
using (var context = new EntityContext())
{
    var customers = context.Customers.ToList();
    customers.ForEach(x => { x.Name += "_Updated"; x.Description += "_Updated"; x.IsActive = false; });
    customers.Take(2).ToList().ForEach(x => { x.ModifiedDate = DateTime.Now; });

    context.BulkMerge(customers, options => 
    {
        options.MergeMatchedAndOneNotConditionExpression = c => new {c.CustomerID, c.ModifiedDate };
    });
}
```

{% include component-try-it.html href='https://dotnetfiddle.net/ptwEKZ' %}

 - It will update all the records except for the last record.
 - The `ModifiedDate` property is only updated for the first two records and not for the last record.
