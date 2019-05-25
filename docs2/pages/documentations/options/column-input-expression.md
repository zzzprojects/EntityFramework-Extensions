# ColumnInputExpression

The `ColumnInputExpression` allows you to choose specific properties of an entity in which you want to perform the bulk operations.

The following example inserts data to the database by specifying `Name` and `IsActive` properties using the `BulkInsert` operation.

```csharp
using (var context = new EntityContext())
{
    context.BulkInsert(list, options => options.ColumnInputExpression = c => new { c.Name, c.IsActive });
}
```

{% include component-try-it.html href='https://dotnetfiddle.net/lwF8DZ' %}

The key is required for operation such as `BulkUpdate` and `BulkMerge`.

```csharp
using (var context = new EntityContext())
{
    List<Customer> list = context.Customers.ToList();
    list.Add(new Customer() { Name ="Customer_C", Description = "Description", IsActive = true });
			
    context.BulkMerge(list, options => 
        options.ColumnInputExpression = c => new {c.CustomerID, c.Name, c.IsActive }
    );
}
```
{% include component-try-it.html href='https://dotnetfiddle.net/NlNP7s' %}
