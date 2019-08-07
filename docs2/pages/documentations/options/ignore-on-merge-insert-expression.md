# Ignore OnMergeInsert Expression

The `IgnoreOnMergeInsertExpression` allows you to ignore some columns when the `BulkMerge` method executes the `insert` statement and these columns will only be used in `update` statement.

The following example ignores the `Description` property in insertion and will be considered when updating the records.

```csharp
using (var context = new EntityContext())
{
    context.BulkMerge(list, options => 
    {
        options.IgnoreOnMergeInsertExpression = customer => new 
        {
            customer.CustomerID,  
            customer.Description
        };
    });
}
```
[Try it in EF6](https://dotnetfiddle.net/ggtMXb) | [Try it in EF Core](https://dotnetfiddle.net/SFCCCZ)
