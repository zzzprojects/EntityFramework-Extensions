# IgnoreOnMergeMatchedAndConditionExpression

The `IgnoreOnMergeMatchedAndConditionExpression` is the inverse of `MergeMatchedAndConditionExpression`.

 -  The `MergeMatchedAndConditionExpression` allows you to perform only the `UPDATE` in the `BulkMerge` if all properties are equal to the database value. 
 -  So by default, all columns are included in `IgnoreOnMergeMatchedAndConditionExpression` but not the one you choose to ignore.

The following example updates all those records by ignoring the specified properties if their value is equal to the database or not.

```csharp
using (var context = new EntityContext())
{
    var customers = context.Customers.ToList();
    customers.ForEach(x => { x.Name += "_Updated"; x.Description += "_Updated"; x.ModifiedDate = DateTime.Now; x.IsActive = false; });
    customers.Last().CreatedDate = DateTime.Now;

    context.BulkMerge(customers, options => 
    {
        options.IgnoreOnMergeMatchedAndConditionExpression = c => new {c.Name, c.Description, c.ModifiedDate, c.IsActive };
    });
}
```

{% include component-try-it.html href='https://dotnetfiddle.net/ooQW8i' %}

 - It will update all the records except for the last record because the `CreatedDate` property is updated for the last record.
