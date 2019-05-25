# IgnoreOnMergeUpdateExpression

The `IgnoreOnMergeInsertExpression` allows you to ignore some columns when the `BulkMerge` method executes the `insert` statement and these columns will only be used in `update` statement.

The following example ignores the `Description` property in insertion and will be considered when updating the records.

```csharp
context.BulkMerge(list, options => 
{
        options.IgnoreOnMergeInsertExpression = customer => new {customer.CustomerID,  customer.Description};
}); 
```
{% include component-try-it.html href='https://dotnetfiddle.net/ggtMXb' %}
