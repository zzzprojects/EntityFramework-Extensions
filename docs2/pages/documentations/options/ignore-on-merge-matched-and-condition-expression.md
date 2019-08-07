# Ignore OnMergeMatched AndCondition Expression

The `IgnoreOnMergeMatchedAndConditionExpression` is the inverse of `MergeMatchedAndConditionExpression`.

 -  The `MergeMatchedAndConditionExpression` allows you to perform only the `UPDATE` in the `BulkMerge` if the specified property value is equal to the database value.  
 -  So by default, all columns are included in `IgnoreOnMergeMatchedAndConditionExpression` but not the one you choose to ignore.

The following example updates all those records in which the `CreatedDate` property is equal to database value and ignores the specified properties in `IgnoreOnMergeMatchedAndConditionExpression` if their value is equal to the database or not.

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
        options.IgnoreOnMergeMatchedAndConditionExpression = c => new 
        {
            c.Name, 
            c.Description, 
            c.ModifiedDate, 
            c.IsActive 
        };
    });
}
```

[Try it in EF6](https://dotnetfiddle.net/ooQW8i) | [Try it in EF Core](https://dotnetfiddle.net/67SGs7)

 - It will update all records except for the last one because the `CreatedDate` property is updated for the last record.
