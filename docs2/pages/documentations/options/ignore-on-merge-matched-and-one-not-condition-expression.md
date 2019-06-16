# Ignore OnMergeMatched AndOneNotCondition Expression

The `IgnoreOnMergeMatchedAndOneNotConditionExpression` is the inverse of `MergeMatchedAndNotConditionExpression` 

 - The `MergeMatchedAndNotConditionExpression` allows you to perform only the `UPDATE` in the `BulkMerge` if the specified property value is not equal to the database value. 
 - So by default, all columns are included in `IgnoreOnMergeMatchedAndOneNotConditionExpression` but not the one you choose to ignore.

The following example updates all those records in which the `ModifiedDate` property is not equal to database value. It ignores the properties specified in `IgnoreOnMergeMatchedAndOneNotConditionExpression` if their value is equal to the database or not.

```csharp
using (var context = new EntityContext())
{
    var customers = context.Customers.ToList();
    customers.ForEach(x => { x.Name += "_Updated"; x.Description += "_Updated"; x.IsActive = false; });
    customers.Take(2).ToList().ForEach(x => { x.ModifiedDate = DateTime.Now; });

    context.BulkMerge(customers, options => 
    {
        options.IgnoreOnMergeMatchedAndOneNotConditionExpression = c => new 
        {
            c.Name, 
            c.Description, 
            c.CreatedDate, 
            c.IsActive 
        };
    });
}
```

{% include component-try-it.html href='https://dotnetfiddle.net/djAD9g' %}

 - It will update all the records except for the last record.
 - The `ModifiedDate` property is only updated for the first two records and not for the last record.
